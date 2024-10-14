using System;
using static C__Training_2.Deligates;

namespace C__Training_2
{
    internal class Deligates
    {
        public delegate void HelloDelegateMethod(string strmeassage);//1st Step.
        public static void Hello(string strmeassage)//2nd Step.
        {
            Console.WriteLine(strmeassage);  
        }
        static void Main()
        {
            HelloDelegateMethod del = new HelloDelegateMethod(Hello);//3rd step.
             del("hello from delegates");
            Console.ReadLine(); 
            //The Delegate is type safe pointer method.

        }
    }
}
