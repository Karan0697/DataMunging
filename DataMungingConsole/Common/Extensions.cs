using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMungingConsole.Common
{
    internal static class Extensions
    {
        /// <summary>
        /// String extension to convert from string to int
        /// </summary>
        public static int ToInt(this string input)
        {
            if (int.TryParse(input.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray(), out int ouput))
            {
                return ouput;
            }
            return 0;
        }
    }
}
