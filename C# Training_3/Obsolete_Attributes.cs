using System;
using System.Collections.Generic;

namespace C__Training_2
{
    internal class Obsolete_Attributes
    {
        public class Calculator
        {
            [Obsolete("Use Add(List<int> Numbers) Method")]
            public static int Add(int Fnum, int Snum)
            {
                return Fnum + Snum;
            }
            public static int Add(List<int> Numbers)
            {
                int Sum = 0;
                foreach (int number in Numbers)
                {
                    Sum = Sum + number;
                }
                return Sum;
            }
        }
        static void Main()
        {
            Console.WriteLine(Calculator.Add(new List<int>() { 10, 20, 30, 40, 50 }));

            Console.ReadLine();
        }
    }
}

