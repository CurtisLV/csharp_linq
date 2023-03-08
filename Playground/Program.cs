using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        var user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        var user2 = Environment.UserName;
        var user3 = Environment.UserDomainName;

        Console.WriteLine(user);
        Console.WriteLine(user2);
        Console.WriteLine(user3);

        //    var students = new List<Student>
        //    {
        //        new Student
        //        {
        //            Marks = new List<int> { 4, 5, 5 }
        //        },
        //        new Student
        //        {
        //            Marks = new List<int> { 5, 6, 5 }
        //        },
        //        new Student
        //        {
        //            Marks = new List<int> { 4, 4, 5 }
        //        },
        //    };

        //    var students2 = new List<Student>
        //    {
        //        new Student
        //        {
        //            Marks = new List<int> { 2, 4, 5 }
        //        },
        //        new Student { Marks = new List<int> { } },
        //        new Student { Marks = new List<int> { } },
        //    };

        //    double MaxAverageOfMarks(IEnumerable<Student> students)
        //    {
        //        if (!students.Any() || students.All(s => !s.Marks.Any()))
        //        {
        //            return 0;
        //        }

        //        return (double)
        //            students.Max(x =>
        //            {
        //                if (x.Marks.Any())
        //                {
        //                    return x.Marks.Average();
        //                }
        //                return 0;
        //            });
        //    }
        //}

        //public class Student
        //{
        //    public IEnumerable<int> Marks { get; set; }
        //
    }
}



//// 23.02.
//var numbers = new[] { 1, 2, 3, 4, 5, 6, 7 };
//var numbers2 = new[] { 1, 2, 3, 4 };

//FirstEvenThenOddDescending(numbers);
//FirstEvenThenOddDescending(numbers2);

//IEnumerable<int> FirstEvenThenOddDescending(IEnumerable<int> numbers)
//{
//    //TODO your code goes here
//    List<int> result = new List<int>();

//    result.AddRange(numbers.Reverse().OrderByDescending(x => x % 2 == 0));

//    return result.ToArray();
//}
