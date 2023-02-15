using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Ragistration
{
    internal class User_data
    {
        public static string UserName = @"^[A-Z][a-z]{3,}$";
        public static string UserLastName = @"^[A-Z][a-z]{3,}$";
        public static string Email = @"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public static string MobNumValidation = @"^[+]91[0-9]{10}$";
        public static string User_password = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%&*-]).{8,}$";

        public void Datacheck() 
        {
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

            Console.WriteLine("Enter Your Pasward..\nplease Enter at least 1 Uppercase\nand 1 numreic numbur\nand one special numbur \nand minimum 8 Character..");
            Regex pass = new Regex(User_data.User_password);
            Console.WriteLine(pass.IsMatch(Console.ReadLine()));

        }
    }
}
