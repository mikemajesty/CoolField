using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolField
{
    public static class CoolField
    {
        public static string UpperCaseOnlyFirst(this TextBox txt, int mininumSize = 1)
        {
            return txt.Text.Length >= mininumSize ? txt.Text.First().ToString().ToUpper() + String.Join("", txt.Text.Skip(1)).ToLower() : "";
        }
   
        public static string UpperCaseAll(this TextBox txt, int mininumSize = 1)
        {
            return txt.Text.Length >= mininumSize ? txt.Text.ToString().ToUpper() : "";
        }
        
        public static string LowerCaseAll(this TextBox txt, int mininumSize = 1)
        {
            return txt.Text.Length >= mininumSize ? txt.Text.ToString().ToLower() : "";
        }
    }
}
