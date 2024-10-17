using System;


namespace CSharp_Training3
{
    internal class Why_should_you_use_override_ToString
    {
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int a { get; set; }
            public int b { get; set; }

            public override string ToString()
            {
                return FirstName + " " + LastName;
            }
        }
        static void Main()
        {
            int Number = 100;
            Console.WriteLine(Number.ToString());
            Customer c = new Customer();
            c.FirstName = "Sasi";
            c.LastName = "Kanth";
            c.a = 1;
            c.b = 2;
            
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
