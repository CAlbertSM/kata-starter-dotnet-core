using System;
using System.Collections.Generic;

namespace Kata
{
    public class Calculator
    {
        public int Add(string numbers = "")
        {
            if (numbers == "")
            {
                return 0;
            }

            if (numbers.Contains(','))
            {
                var aNumbers = numbers.Split(',');
                return Int32.Parse(aNumbers[0]) + Int32.Parse(aNumbers[1]);
            }
            return Int32.Parse(numbers);
        }
    }
}