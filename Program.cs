using System;
using System.Text.RegularExpressions;

namespace User_Ragistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Program");

           User_data data= new User_data();
            data.Datacheck();
           


        }
    }
}
