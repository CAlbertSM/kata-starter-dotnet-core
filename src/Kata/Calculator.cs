using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string numbers = "")
        {
            if (numbers == "") return 0;

            var separator = new[] {",", "\n"};
            var exceptionMessage = "negatives not allowed: ";

            if (numbers.Contains("//"))
            {
                var parts = numbers.Split("\n");

                separator = new[] {parts[0].Replace("//", "")};
                numbers = parts[1];
            }

            var ints = numbers.Split(separator, StringSplitOptions.None).Select(int.Parse).ToList();

            var negatives = ints.Where(x => x < 0);
            if (negatives.Any()) throw new Exception(exceptionMessage + string.Join(", ", negatives));

            return ints.Sum();
        }
    }
}