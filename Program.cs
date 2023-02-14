﻿using System;
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

            Console.WriteLine("User Last Name:");
            Regex last = new Regex(User_data.UserLastName);
            Console.WriteLine(last.IsMatch(Console.ReadLine()));

            Console.WriteLine("User Enter valid E-mail:");
            Regex emails = new Regex(User_data.Email);
            Console.WriteLine(emails.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter Your mobile numbur(+91):");
            Regex mob = new Regex(User_data.MobNumValidation);
            Console.WriteLine(mob.IsMatch(Console.ReadLine()));


            Console.WriteLine("Enter Your Pasward..:\nplease Enter at least minimum 8 Character..");
            Regex pass = new Regex(User_data.User_password);
            Console.WriteLine(pass.IsMatch(Console.ReadLine())); 


        }
    }
}
