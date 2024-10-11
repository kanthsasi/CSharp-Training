using System;

namespace c__Training
{
    internal class Interface
    {
        //Interfaces have only declaration.
        //Interface does not have implementation.
        interface ICustomer1
        {
            void print1();
            void print3();
        }
        interface ICustomer2:ICustomer1
        {
            void print2();
        }
        public class Customer : ICustomer1, ICustomer2
        {
            public void print1()
            {
                Console.WriteLine("Print1");
            }
            public void print2()
            {
                Console.WriteLine("Print2");
            }
            public void print3()
            {
                Console.WriteLine("Print3");
            }
            public class Customer1:ICustomer2
            {
                public void print2()
                {
                    Console.WriteLine(1);
                }
                public void print1()
                {
                    Console.WriteLine(2);
                }
                public void print3()
                {
                    Console.WriteLine(3);
                }
            }

        }
        static void Main()
        {
            Customer c = new Customer();
            c.print1();
            c.print2();
            c.print3();
            ICustomer2 c1 = new Customer.Customer1();
            Console.ReadLine();
        }
    }
}
