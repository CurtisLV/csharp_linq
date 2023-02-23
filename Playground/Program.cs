using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7 };
        var numbers2 = new[] { 1, 2, 3, 4 };

        FirstEvenThenOddDescending(numbers);
        FirstEvenThenOddDescending(numbers2);

        IEnumerable<int> FirstEvenThenOddDescending(IEnumerable<int> numbers)
        {
            //TODO your code goes here
            List<int> result = new List<int>();

            result.AddRange(numbers.OrderByDescending(x => x % 2 == 0));
            result.AddRange(numbers.OrderByDescending(x => x % 2 == 1));

            return result.ToArray();
        }
    }
}
