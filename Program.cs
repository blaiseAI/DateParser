using System;

namespace DateParser
{
    class Program
    {
        public static DateTime DateParser()
        {
            bool DoItAgain = true;
            DateTime parsedDate = DateTime.Now;
            while (DoItAgain)
            {
                try
                {
                    Console.Write("\nEnter a date you want to parse: ");
                    string DateInput = Console.ReadLine();
                    parsedDate = DateTime.Parse(DateInput);
                    Console.WriteLine(parsedDate);
                    //DayTime();
                    Console.WriteLine("Do you want to try another date Y/N: ");
                    if (char.ToLower(Console.ReadKey().KeyChar) == 'n')
                    {
                        Console.WriteLine();
                        DoItAgain = false;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Date Format");
                }
            }

            return parsedDate;
        }
        static void Main(string[] args)
        {
            DateParser();
        }
    }
}
