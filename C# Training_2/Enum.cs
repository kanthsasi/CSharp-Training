using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Training_2
{
    internal class Enum
    {
        public class Customer
        {
            public string Name { get; set; }
            public Gender gender { get; set; }
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
        public enum Gender
        {
            Unknown=0,
            Male=1,
            Female=2
        }

        static void Main()
        {
            Customer[] c = new Customer[3];
            c[0] = new Customer
            {
                Name = "SasiKanth",
                gender = Gender.Male
            };
            c[1] = new Customer
            { 
                Name="Sanjiv",
                gender=Gender.Male
            };
            c[2] = new Customer
            {
                Name="Manoj",
                gender=Gender.Female
            };
            foreach (Customer customer in c)
            {
                Console.WriteLine("Name:"+ customer.Name+ " && "+ "Gender:"+GetGender(customer.gender));
            }

            
            Console.ReadLine();
        }
    }
}
