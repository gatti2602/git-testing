using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Nico's book");
            book.AddGrade(85.1);
            book.AddGrade(53.1);
            book.AddGrade(45.1);
            book.AddGrade(33.1);
            var result = book.GetStats();

            Console.WriteLine($"The average are {result.Average:N1}");
            Console.WriteLine($"The Max is {result.High:N1}");
            Console.WriteLine($"The Min is {result.Low:N1}");
        }
    }
}
