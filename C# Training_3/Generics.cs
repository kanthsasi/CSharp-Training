using System;


namespace CSharp_Training3
{
    internal class Generics
    {
        public class Calculator
        {
            public static bool AreEqual<S>( S value1,  S value2)//===>Create Generics<S>
            {
                return value1.Equals(value2);
            }
        }

        static void Main()
        {
            bool Equal=Calculator.AreEqual(10.0F,10.0F);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadLine();
            
        }
    }
}
