using System;

namespace Birth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birthYear, birthMonth, birthDay;
            bool isValidInput = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter your birth year: ");
                birthYear = int.Parse(Console.ReadLine());
                if (birthYear <= 2023)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid year.");
                }
            } while (!isValidInput);

            isValidInput = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter your birth month: ");
                if (int.TryParse(Console.ReadLine(), out birthMonth) && birthMonth >= 1 && birthMonth <= 12)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid month (1-12).");
                }
            } while (!isValidInput);

            isValidInput = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter your birth day: ");
                if (int.TryParse(Console.ReadLine(), out birthDay) && birthDay >= 1 && birthDay <= 31)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid day (1-31).");
                }
            } while (!isValidInput);

            Console.WriteLine();

            DateTime dateTime = new DateTime(birthYear, birthMonth, birthDay);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your birth: {dateTime}");
            Console.ResetColor();

            DateTime now = DateTime.Now;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Now time: {now.Month}/{now.Day}/{now.Year}");
            Console.ResetColor();
            Console.WriteLine();

            TimeSpan elapsedTime = now - dateTime;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You were born {elapsedTime.Days / 365} years, {elapsedTime.Days % 365 / 30} months,{elapsedTime.Days % 365 % 30} days ago");
            Console.ResetColor();
            
        }
    }
}
