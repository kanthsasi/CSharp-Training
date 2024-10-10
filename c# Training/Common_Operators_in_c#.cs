using System;

namespace c__Training
{
    internal class Common_Operators_in_c_
    {
        static void Main()
        {
            int Numbers;
            int Number2 = 20;

            Numbers = 10;

            int Result = Numbers + Number2;
            Console.WriteLine("Result:"+Result);
            //Terinary Operator
            bool ifnumber10 = Number2 == 10 ? true : false;
            Console.WriteLine(ifnumber10);
            Console.ReadLine();
        }
    }
}
