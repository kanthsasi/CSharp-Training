using System;


namespace C__Training_2
{
    internal class Multiple_Class_Inheritance
    {
        interface IA
        {
            void Amethod();
        }
        public class A : IA
        {
            public void Amethod()
            {
                Console.WriteLine("A implementation");
            }
        }
            interface IB
            {
                void Bmethod();
            }
            public class B : IB
            {
                public void Bmethod()
                {
                    Console.WriteLine("B implementation");
                }
            }
        public class AB : IA, IB
        {
            A a = new A();
            B b = new B();
            public void Amethod()
            {
                a.Amethod();
            }
            public void Bmethod()
            {
                b.Bmethod();
            }
        }
        
        static void Main()
        {
            AB ab = new AB();
            ab.Amethod();
            ab.Bmethod();
            Console.ReadLine();
        }
    }
}
