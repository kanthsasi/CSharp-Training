using System;

namespace CSharp_Training3
{
    internal class Why_should_you_override_Equals
    {
        /*public enum Direction
        {
            east=1,
            west=2,
            north=3,
            south=4
        }*/
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                if (!(obj is Customer))
                {
                    return false;
                }
                return this.FirstName == ((Customer)obj).FirstName &&
                    this.LastName == ((Customer)obj).LastName;
            }
            public override int GetHashCode()
            {
                return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
            }
        }

        static void Main()
        {
            /* Direction direction1 = Direction.east;
             Direction direction2 = Direction.east;
             Console.WriteLine(direction1.Equals(direction2));*/
            /*Customer c = new Customer();
            c.FirstName = "Sasi";
            c.LastName = "Kanth";
            Customer c1 = c;*/
            Customer C1 = new Customer();
            C1.FirstName = "Sasi";
            C1.LastName = "Kanth";
            Customer C2 = new Customer();
            C2.FirstName = "Sasi";
            C2.LastName = "Kanth";

            Console.WriteLine(C1.Equals(C2));
            Console.WriteLine(C1.FirstName.Equals(C2.LastName));
            Console.ReadLine();
            
        }
    }
}
