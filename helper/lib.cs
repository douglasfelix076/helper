using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    public static class functions2
    {

        public static string hexColor(this string text)
        {
            if (text.Contains("]"))
            {
                text = text.Replace("]", ">");
            }
            bool flag2 = false;
            while (text.Contains("[") && !flag2)
            {
                int index = text.IndexOf("[");
                if (text.Length >= (index + 7))
                {
                    string str = text.Substring(index + 1, 6);
                    text = text.Remove(index, 7).Insert(index, "<color=#" + str);
                    int length = text.Length;
                    if (text.Contains("["))
                    {
                        length = text.IndexOf("[");
                    }
                    text = text.Insert(length, "</color>");
                }
                else
                {
                    flag2 = true;
                }
            }
            if (flag2)
            {
                return string.Empty;
            }
            return text;
        }

        /// new Color(1,1,1,1) => "FFFFFF"
        public static string ToHex(this Color c, bool useAlpha = false)
        {
           return (c.R).ToString("X2") + (c.G).ToString("X2") + (c.B).ToString("X2") + ((useAlpha) ? (c.A).ToString("X2") : "");
        }

        public static T KeyByValue<T, W>(this Dictionary<T, W> dict, W val)
        {
            T key = default;
            foreach (KeyValuePair<T, W> pair in dict)
            {
                if (EqualityComparer<W>.Default.Equals(pair.Value, val))
                {
                    key = pair.Key;
                    break;
                }
            }
            return key;
        }
    }
}
