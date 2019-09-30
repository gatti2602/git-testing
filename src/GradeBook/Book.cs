using System;
using System.Collections.Generic;

namespace GradeBook
{
    //internal class Book <- por defecto
    public class Book
    {
        //No se usa var en fields de clases
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStats()
        {
            var result = new Statistics();
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            foreach(var number in grades)
            {
                result.Low = Math.Min(result.Low, number);
                result.High = Math.Max(result.High,number);
                result.Average += number;
            }
            result.Average /= grades.Count;
            return result;
        }
    }
}