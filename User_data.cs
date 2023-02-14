using System;
using System.Collections.Generic;
using System.Text;

namespace User_Ragistration
{
    internal class User_data
    {
        public static string UserName = @"^[A-Z][a-z]{3,}$";
        public static string UserLastName = @"^[A-Z][a-z]{3,}$";
        public static string Email = @"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public static string MobNumValidation = @"^[+]91[0-9]{10}$";

    }
}
