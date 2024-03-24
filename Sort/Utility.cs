using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sort
{
    public class Utility
    {
        public static int GetHashCode(string strHash)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(strHash), Base64FormattingOptions.None).GetHashCode();
        }
    }
}
