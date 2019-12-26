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

            var separator = new[]{",","\n"};
            
            if (numbers.Contains("//"))
            {
                var parts = numbers.Split("\n");
                
                separator = new[] {parts[0].Replace("//","")};
                numbers = parts[1];
            }

            return numbers.Split(separator, StringSplitOptions.None).Select(int.Parse).Sum();
        }
    }
}