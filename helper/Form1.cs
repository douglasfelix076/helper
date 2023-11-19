using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using functions;

namespace helper
{
    public partial class main_panel : Form
    {
        private OpenFileDialog ofd;
        private Image rawimage = null;
        private int maxZoomLevel = 8;
        private int zoomLevel = 3;

        public main_panel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            OptionsButtonsEnabled(false);
        }
        private void Open_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the file name and set the zoom level
                    var fileName = Path.GetFileName(ofd.FileName);
                    zoomLevel = 3;

                    // Load the image and update UI elements
                    using (Image loadedImage = Image.FromFile(ofd.FileName))
                    {
                        open_image.Text = fileName;
                        Preview_box.Image = newImage(loadedImage, zoomLevel);
                        width_label.Text = "W: " + loadedImage.Width;
                        height_label.Text = "H: " + loadedImage.Height;
                    }

                    OptionsButtonsEnabled(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_box_Click(object sender, EventArgs e)
        {
            output_box.ResetText();
        }

        private void copy_content_Click(object sender, EventArgs e)
        {

            Clipboard.SetDataObject(output_box.Text);
        }

        private async void convert_image_Click_1(object sender, EventArgs e)
        {
            if (rawimage != null)
            {
                ButtonsEnabled(false);

                await ImageToText(new Bitmap(rawimage));

                ButtonsEnabled(true);
                count_label.Text = "Character count: " + output_box.Text.Length;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void zoom_out_Click(object sender, EventArgs e)
        {
            // -
            zoomLevel = Math.Max(zoomLevel - 1, 1);
            updateImageZoom();
        }

        private void zoom_in_Click(object sender, EventArgs e)
        {
            // +
            zoomLevel = Math.Min(zoomLevel + 1, maxZoomLevel);
            updateImageZoom();
        }

        private void updateImageZoom()
        {
            if (rawimage != null)
            {
                Preview_box.Image = newImage(rawimage, zoomLevel);
            }
        }

        private Image newImage(Image image, int scale)
        {
            Bitmap newimg = new Bitmap(image.Width * scale, image.Height * scale);

            using (Graphics g = Graphics.FromImage(newimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(image, new Rectangle(Point.Empty, newimg.Size));
            }

            return newimg; ;
        }

        private async Task ImageToText(Bitmap image)
        {
            // commence epic spaghetti code
            await Task.Run(() =>
            {
                output_box.ResetText();
                Dictionary<int, Color> usedColors = new Dictionary<int, Color>(); // stores all the colors
                var colorid = 0;
                for (int i = 0; i < image.Height; i++)
                {
                    StringBuilder result = new StringBuilder();
                    int prevID = -1;
                    for (int j = 0; j < image.Width; j++)
                    {
                        var color = image.GetPixel(j, i);
                        int id;
                        if (!usedColors.ContainsValue(color))
                        {
                            id = colorid;
                            usedColors.Add(colorid++, color);
                        }
                        else
                        {
                            id = usedColors.KeyByValue(color);
                        }

                        if (id != prevID)
                        {
                            result.Append("[" + usedColors[id].ToHex(color.A != 255) + "]");
                        }
                        result.Append("█");
                        prevID = id;
                    }
                    string row = result.ToString();

                    // individual line formatting
                    if (!raw_hex_check.Checked)
                    {
                        row = row.hexColor();
                    }
                    if (!single_line_check.Checked)
                    {
                        if (coding_check.Checked)
                        {
                            if (custom_size_check.Checked && !raw_hex_check.Checked)
                            {
                                row = $"<size={size_number.Value}%>{row}</size>";
                            }
                            row = $"rows.Add(\"{row}\");";
                        }
                        row = Environment.NewLine + row;
                    }
                    else
                    {
                        row += "\n";
                    }
                    UpdateOutputBox(row);
                }
                // general formatting
            
                if (custom_size_check.Checked && (single_line_check.Checked || !coding_check.Checked))
                {
                    output_box.Text = $"<size={size_number.Value}%>{output_box.Text}</size>";
                }
                if (coding_check.Checked)
                {
                    if (single_line_check.Checked)
                    {
                        output_box.Text = $"rows.Add(\"{output_box.Text}\");";
                    }
                    output_box.Text = $"List<string> rows = new List<string>();" + output_box.Text;
                }
            });
        }

        private void UpdateOutputBox(string text)
        {
            if (output_box.InvokeRequired)
            {
                output_box.Invoke(new Action<string>(UpdateOutputBox), text);
            }
            else
            {
                output_box.AppendText(text);
            }
        }

        private void Preview_box_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            size_number.Enabled = custom_size_check.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonsEnabled(bool enabled)
        {
            clear_box.Enabled = enabled;
            copy_content.Enabled = enabled;
            ww_check.Enabled = enabled;
            zoom_in.Enabled = enabled;
            zoom_out.Enabled = enabled;
            OptionsButtonsEnabled(enabled);
        }

        private void OptionsButtonsEnabled(bool enabled)
        {
            coding_check.Enabled = enabled;
            custom_size_check.Enabled = enabled;
            size_number.Enabled = enabled ? custom_size_check.Enabled : false;
            single_line_check.Enabled = enabled;
            raw_hex_check.Enabled = enabled;
        }

        private void coding_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void enable_hex_box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void size_number_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void line_break_check_CheckedChanged(object sender, EventArgs e)
        {
            output_box.WordWrap = ww_check.Checked;
        }

        private void width_label_Click(object sender, EventArgs e)
        {

        }

        private void count_label_Click(object sender, EventArgs e)
        {

        }
    }
}