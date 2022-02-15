using System;

namespace Lesson1_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first name:");
            var firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            var lastname = Console.ReadLine();

            Console.WriteLine($"User's first name is {firstname},user's last name is {lastname} ");
        }
    }
}
