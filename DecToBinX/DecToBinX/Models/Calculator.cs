﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecToBinX
{
    class Calculator
    {
        /// <summary>
        /// Variable for storing a string process (Decimal to Binary convert)
        /// </summary>
        public string Process { get; set; }

        /// <summary>
        /// Decimal to binary convert
        /// </summary>
        /// <param name="numberInput">Decimal number, target to convert to binary</param>
        internal string Input(double numberInput)
        {
            Process = "";
            numberInput = Math.Floor(numberInput);
            string numberOutput = "";
            string modulo;
            if (numberInput != 0)
            {

            }
            while (numberInput != 1)
            {
                if (numberInput % 2 == 0) //even
                {
                    numberOutput += "0";
                    modulo = "0";
                }

                else //odd
                {
                    numberOutput += "1";
                    modulo = "1";
                }

                Process += $"{numberInput} | {modulo} \n";
                numberInput = Math.Floor(numberInput /= 2);
            }
            Process += "0 | 1";
            numberOutput += "1";

            return Utilities.Reverse(numberOutput);
        }


    }
}
