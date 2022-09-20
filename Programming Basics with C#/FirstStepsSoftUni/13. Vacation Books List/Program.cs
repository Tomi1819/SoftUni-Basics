using System;

namespace _13._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalReadingTime = pages / pagesPerHour;
            int neededHours = totalReadingTime / days;
            Console.WriteLine(neededHours);
        }
    }
}
