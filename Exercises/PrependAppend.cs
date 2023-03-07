using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class PrependAppend
    {
        //Coding Exercise 1
        /*
        Using LINQ, implement the AddStartAndEndMarkers which given a collection
        of words, will add "START" at the beginning and "END" at the end,
        unless those markers were already present.

        For example:
            *For input {"AAA", "BBB"} the result shall be
                {"START", "AAA", "BBB", "END"}
            *For input {"START", "AAA", "BBB"} the result shall be
                {"START", "AAA", "BBB", "END"}
            *For input {"AAA", "BBB", "END"} the result shall be
                {"START", "AAA", "BBB", "END"}
            *For input {"START", "AAA", "BBB", "END"} the result shall be
                {"START", "AAA", "BBB", "END"}

        We don't care if words "START" and "END" are anywhere else in the collection.
        For example:
            *For input {"AAA", "START",  "END", "BBB",  "START"} the result shall be
                {"START", "AAA", "START",  "END", "BBB",  "START", "END"}
         */
        public static IEnumerable<string> AddStartAndEndMarkers(IEnumerable<string> words)
        {
            var answer = words;

            if (words.First() != "START")
            {
                answer = answer.Prepend("START");
            }

            if (words.Last() != "END")
            {
                answer = answer.Append("END");
            }

            return answer;
        }

        //Coding Exercise 2
        /*
        Implement the RemoveDuplicatesFromStartAndEnd method, which given
        a collection of ordered numbers, will remove the duplicate occurrences
        of the first and the last number in the collection.

        For example:
            *for numbers {2, 2, 2, 5, 6, 6 ,6 , 7, 7, 7} the result shall be
                {2, 5, 6, 6, 6 , 7}. Please note that only duplicates of 2 and 7
                were removed, because they are the first and the last numbers.
                The duplicates of 6 have not been removed.
            *for numbers {2, 5, 6, 6 ,6 , 7, 7, 7} the result shall be
                {2, 5, 6, 6, 6 , 7}. Please note that only duplicates of 2 and 7 were
                removed, because they are the first and the last numbers.
                The duplicates of 6 have not been removed.
        */
        public static IEnumerable<int> RemoveDuplicatesFromStartAndEnd(IEnumerable<int> numbers)
        {
            if (numbers.Count() < 2)
            {
                return numbers;
            }

            return numbers
                .Where(number => number != numbers.First())
                .Prepend(numbers.First())
                .Where(number => number != numbers.Last())
                .Append(numbers.Last());
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> TrimSentenceAndChangeEndMarker_Refactored(
            IEnumerable<string> words
        )
        {
            return words.TakeWhile(word => word != "The end").Append("END");
        }

        //do not modify this method
        public static IEnumerable<string> TrimSentenceAndChangeEndMarker(IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word != "The end")
                {
                    result.Add(word);
                }
                else
                {
                    break;
                }
            }
            result.Add("END");
            return result;
        }
    }
}
