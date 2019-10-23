using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(20.3);
            book.AddGrade(68.5);
            book.ShowStatistics();
        }
    }
}
