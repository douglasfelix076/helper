namespace helper
{
    partial class main_panel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_panel));
            open_image = new Button();
            output_box = new TextBox();
            clear_box = new Button();
            copy_content = new Button();
            convert_image = new Button();
            Preview_box = new PictureBox();
            output_label = new Label();
            zoom_in = new Button();
            zoom_out = new Button();
            single_line_check = new CheckBox();
            size_number = new NumericUpDown();
            coding_check = new CheckBox();
            raw_hex_check = new CheckBox();
            label1 = new Label();
            options_panel = new Panel();
            custom_size_check = new CheckBox();
            ww_check = new CheckBox();
            count_label = new Label();
            width_label = new Label();
            height_label = new Label();
            ((System.ComponentModel.ISupportInitialize)Preview_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)size_number).BeginInit();
            options_panel.SuspendLayout();
            SuspendLayout();
            // 
            // open_image
            // 
            open_image.AutoEllipsis = true;
            open_image.Location = new Point(178, 12);
            open_image.Name = "open_image";
            open_image.Size = new Size(270, 41);
            open_image.TabIndex = 1;
            open_image.Text = "Choose Image";
            open_image.UseVisualStyleBackColor = true;
            open_image.Click += Open_Click;
            // 
            // output_box
            // 
            output_box.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            output_box.Location = new Point(12, 223);
            output_box.MaxLength = 327670;
            output_box.Multiline = true;
            output_box.Name = "output_box";
            output_box.ReadOnly = true;
            output_box.Size = new Size(436, 219);
            output_box.TabIndex = 3;
            output_box.WordWrap = false;
            output_box.TextChanged += output_TextChanged;
            // 
            // clear_box
            // 
            clear_box.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clear_box.Location = new Point(320, 448);
            clear_box.Name = "clear_box";
            clear_box.Size = new Size(61, 24);
            clear_box.TabIndex = 4;
            clear_box.Text = "Clear";
            clear_box.UseVisualStyleBackColor = true;
            clear_box.Click += clear_box_Click;
            // 
            // copy_content
            // 
            copy_content.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            copy_content.Location = new Point(387, 448);
            copy_content.Name = "copy_content";
            copy_content.Size = new Size(61, 24);
            copy_content.TabIndex = 5;
            copy_content.Text = "Copy";
            copy_content.UseVisualStyleBackColor = true;
            copy_content.Click += copy_content_Click;
            // 
            // convert_image
            // 
            convert_image.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            convert_image.Location = new Point(12, 448);
            convert_image.Name = "convert_image";
            convert_image.Size = new Size(61, 24);
            convert_image.TabIndex = 7;
            convert_image.Text = "Convert";
            convert_image.UseVisualStyleBackColor = true;
            convert_image.Click += convert_image_Click_1;
            // 
            // Preview_box
            // 
            Preview_box.BorderStyle = BorderStyle.FixedSingle;
            Preview_box.Location = new Point(12, 12);
            Preview_box.Name = "Preview_box";
            Preview_box.Size = new Size(160, 160);
            Preview_box.TabIndex = 8;
            Preview_box.TabStop = false;
            Preview_box.Click += Preview_box_Click;
            // 
            // output_label
            // 
            output_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            output_label.AutoSize = true;
            output_label.Location = new Point(12, 205);
            output_label.Name = "output_label";
            output_label.Size = new Size(48, 15);
            output_label.TabIndex = 9;
            output_label.Text = "Output:";
            output_label.Click += label2_Click;
            // 
            // zoom_in
            // 
            zoom_in.Location = new Point(41, 178);
            zoom_in.Name = "zoom_in";
            zoom_in.Size = new Size(23, 23);
            zoom_in.TabIndex = 10;
            zoom_in.Text = "+";
            zoom_in.UseVisualStyleBackColor = true;
            zoom_in.Click += zoom_in_Click;
            // 
            // zoom_out
            // 
            zoom_out.Location = new Point(12, 178);
            zoom_out.Name = "zoom_out";
            zoom_out.Size = new Size(23, 23);
            zoom_out.TabIndex = 11;
            zoom_out.Text = "-";
            zoom_out.UseVisualStyleBackColor = true;
            zoom_out.Click += zoom_out_Click;
            // 
            // single_line_check
            // 
            single_line_check.AutoSize = true;
            single_line_check.Location = new Point(3, 3);
            single_line_check.Name = "single_line_check";
            single_line_check.Size = new Size(79, 19);
            single_line_check.TabIndex = 15;
            single_line_check.Text = "single line";
            single_line_check.UseVisualStyleBackColor = true;
            single_line_check.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // size_number
            // 
            size_number.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            size_number.Enabled = false;
            size_number.ImeMode = ImeMode.NoControl;
            size_number.Location = new Point(201, 24);
            size_number.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            size_number.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            size_number.Name = "size_number";
            size_number.Size = new Size(42, 23);
            size_number.TabIndex = 16;
            size_number.Value = new decimal(new int[] { 1, 0, 0, 0 });
            size_number.ValueChanged += size_number_ValueChanged;
            // 
            // coding_check
            // 
            coding_check.AutoSize = true;
            coding_check.Location = new Point(3, 28);
            coding_check.Name = "coding_check";
            coding_check.Size = new Size(89, 19);
            coding_check.TabIndex = 17;
            coding_check.Text = "code syntax";
            coding_check.UseVisualStyleBackColor = true;
            coding_check.CheckedChanged += coding_check_CheckedChanged;
            // 
            // raw_hex_check
            // 
            raw_hex_check.AutoSize = true;
            raw_hex_check.Location = new Point(3, 53);
            raw_hex_check.Name = "raw_hex_check";
            raw_hex_check.Size = new Size(67, 19);
            raw_hex_check.TabIndex = 18;
            raw_hex_check.Text = "raw hex";
            raw_hex_check.UseVisualStyleBackColor = true;
            raw_hex_check.CheckedChanged += enable_hex_box_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 70);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 19;
            label1.Text = "Options:";
            label1.Click += label1_Click_2;
            // 
            // options_panel
            // 
            options_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            options_panel.BorderStyle = BorderStyle.FixedSingle;
            options_panel.Controls.Add(single_line_check);
            options_panel.Controls.Add(size_number);
            options_panel.Controls.Add(raw_hex_check);
            options_panel.Controls.Add(custom_size_check);
            options_panel.Controls.Add(coding_check);
            options_panel.Location = new Point(178, 88);
            options_panel.Name = "options_panel";
            options_panel.Size = new Size(270, 84);
            options_panel.TabIndex = 20;
            // 
            // custom_size_check
            // 
            custom_size_check.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            custom_size_check.AutoSize = true;
            custom_size_check.Location = new Point(155, 3);
            custom_size_check.Name = "custom_size_check";
            custom_size_check.Size = new Size(88, 19);
            custom_size_check.TabIndex = 13;
            custom_size_check.Text = "custom size";
            custom_size_check.UseVisualStyleBackColor = true;
            custom_size_check.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ww_check
            // 
            ww_check.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ww_check.AutoSize = true;
            ww_check.Location = new Point(396, 204);
            ww_check.Name = "ww_check";
            ww_check.Size = new Size(52, 19);
            ww_check.TabIndex = 21;
            ww_check.Text = "wrap";
            ww_check.TextAlign = ContentAlignment.MiddleRight;
            ww_check.UseVisualStyleBackColor = true;
            ww_check.CheckedChanged += line_break_check_CheckedChanged;
            // 
            // count_label
            // 
            count_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            count_label.AutoSize = true;
            count_label.Location = new Point(79, 453);
            count_label.Name = "count_label";
            count_label.Size = new Size(95, 15);
            count_label.TabIndex = 22;
            count_label.Text = "Character count:";
            count_label.Click += count_label_Click;
            // 
            // width_label
            // 
            width_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            width_label.AutoSize = true;
            width_label.Location = new Point(79, 182);
            width_label.Name = "width_label";
            width_label.Size = new Size(21, 15);
            width_label.TabIndex = 23;
            width_label.Text = "W:";
            width_label.Click += width_label_Click;
            // 
            // height_label
            // 
            height_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            height_label.AutoSize = true;
            height_label.Location = new Point(120, 182);
            height_label.Name = "height_label";
            height_label.Size = new Size(19, 15);
            height_label.TabIndex = 24;
            height_label.Text = "H:";
            // 
            // main_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 484);
            Controls.Add(height_label);
            Controls.Add(width_label);
            Controls.Add(count_label);
            Controls.Add(ww_check);
            Controls.Add(label1);
            Controls.Add(zoom_out);
            Controls.Add(zoom_in);
            Controls.Add(output_label);
            Controls.Add(Preview_box);
            Controls.Add(convert_image);
            Controls.Add(copy_content);
            Controls.Add(clear_box);
            Controls.Add(output_box);
            Controls.Add(open_image);
            Controls.Add(options_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "main_panel";
            Text = "Helper";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Preview_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)size_number).EndInit();
            options_panel.ResumeLayout(false);
            options_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button open_image;
        private TextBox output_box;
        private Button clear_box;
        private Button copy_content;
        private Button convert_image;
        private PictureBox Preview_box;
        private Label output_label;
        private Button zoom_in;
        private Button zoom_out;
        private CheckBox single_line_check;
        private NumericUpDown size_number;
        private CheckBox coding_check;
        private CheckBox raw_hex_check;
        private Label label1;
        private Panel options_panel;
        private CheckBox custom_size_check;
        private CheckBox ww_check;
        private Label count_label;
        private Label width_label;
        private Label height_label;
    }
}