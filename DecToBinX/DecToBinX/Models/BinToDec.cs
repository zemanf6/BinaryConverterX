using System;
using System.Collections.Generic;
using System.Text;

namespace DecToBinX.Models
{
    class BinToDec
    {
        /// <summary>
        /// Storing a string process (Binary to decimal)
        /// </summary>
        public string BinProcess { get; set; }

        /// <summary>
        /// Storing a simpler and shorter process (Binary to decimal)
        /// </summary>
        public string BinSimpleProcess { get; set; }

        /// <summary>
        /// Binary to decimal
        /// </summary>
        /// <param name="numberInput">Input in binary, convert to decimal</param>
        public double BinInput(double numberInput)
        {
            BinProcess = "";

            double numberOutput = 0;
            string inputString = Utilities.Reverse(numberInput.ToString());

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '1')
                {
                    numberOutput += Math.Pow(2, i);
                    BinProcess += $"(2^{i} * 1) + ";
                }
                else
                {
                    BinProcess += $"(2^{i} * 0) + ";
                }
            }

            return numberOutput;
        }
    }
}
