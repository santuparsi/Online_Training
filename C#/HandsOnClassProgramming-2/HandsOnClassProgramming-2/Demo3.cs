using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnClassProgramming_2
{
    class User
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime DOB { get; set; }
        public static string Country { get; set; }
        public static string City { get; set; }
    }

    class Demo3
    {
        static void Main()
        {
            User obj = new User();
            obj.Fname = "Rohan";
            obj.Lname = "Gupta";
            User.Country = "India";
            User.City = "Banglore";
            User user1 = new User() { Fname = "Sachin", Lname = "Tendulkar", DOB = new DateTime(1970, 12, 23) };
            User user2 = new User() { Fname = "Sachin", Lname = "Tendulkar", DOB = DateTime.Parse("12/2/1978") };


        }
    }
}
