using System;
using System.Text.RegularExpressions;

namespace User_Ragistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Program");

            Console.WriteLine("\nEnter User Name:");
            Regex user = new Regex(User_data.UserName);
            Console.WriteLine(user.IsMatch(Console.ReadLine()));
            Console.WriteLine("Done");

            Console.WriteLine("User Last Name:");
            Regex last = new Regex(User_data.UserLastName);
           Console.WriteLine(last.IsMatch (Console.ReadLine()));
        }
    }
}
