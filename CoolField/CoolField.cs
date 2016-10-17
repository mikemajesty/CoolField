using System;
using System.Linq;
using System.Windows.Forms;

namespace CoolField
{
    public static class CoolField
    {
        public static string ToUpperCaseOnlyFirst(this TextBox txt, int mininumSize = 1)
        {
            return txt.Text.Length >= mininumSize ? txt.Text.First().ToString().ToUpper() + String.Join("", txt.Text.Skip(1)).ToLower() : "";
        }

        public static string ToUpperCaseAll(this TextBox txt, int mininumSize = 1)
        {
            return txt.Text.Length >= mininumSize ? txt.Text.ToString().ToUpper() : "";
        }

        public static string ToLowerCaseAll(this TextBox txt, int mininumSize = 1)
        {
            return txt.Text.Length >= mininumSize ? txt.Text.ToString().ToLower() : "";
        }
    }
}
