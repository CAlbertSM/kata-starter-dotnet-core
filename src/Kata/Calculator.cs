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
            var exceptionMessage = "negatives not allowed: ";
            
            if (numbers.Contains("//"))
            {
                var parts = numbers.Split("\n");
                
                separator = new[] {parts[0].Replace("//","")};
                numbers = parts[1];
            }

            return numbers.Split(separator, StringSplitOptions.None).Select((number) =>
            {
                if (Int32.Parse(number) < 0)
                {
                    exceptionMessage += number;
                    throw new Exception(exceptionMessage);
                }
                else
                {
                    return Int32.Parse(number);
                }
            }).Sum();
        }
    }
}