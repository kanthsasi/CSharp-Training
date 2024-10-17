using System;

namespace c__Training
{
    internal class Abstract_Class
    {
        public abstract class Customer
        {
            public abstract void print();
            public abstract void print2();

        }
        public class Customer1 : Customer
        {
            public override void print()
            {
                Console.WriteLine(1);
            }
            public override void print2()
            {
                Console.WriteLine(2);
            }
        }
        static void Main()
        {
            Customer v = new Customer1();
            v.print();
            v.print2();
            Console.ReadLine();

        }
    }
}

