using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Book
    {
        private List<double> grades;
        private string name;
        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }else
            {
                Console.WriteLine("Invalid value");
            }
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;*
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");*****
        }

    }
}
