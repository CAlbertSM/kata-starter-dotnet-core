using System;
using System.Collections.Generic;
using System.Linq;

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
            
            return numbers.Replace('\n', ',').Split(",").Select(int.Parse).Sum();
        }
    }
}