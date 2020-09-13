using System;
using System.Collections.Generic;
using System.Text;

namespace DecToBinX
{
    static class Utilities
    {
        /// <summary>
        /// Reverse string
        /// </summary>
        /// <param name="s">String to reverse</param>
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
