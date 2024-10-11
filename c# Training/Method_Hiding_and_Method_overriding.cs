using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Method_Hiding_and_Method_overriding
    {
        public class BaseClass
        {
            public virtual void Print()
            {
                Console.WriteLine("I am the base class");
            }
        }
        public class DerivedClass : BaseClass
        {
            //public  new void Print()---->This is for Method Hiding.
            public override void Print()//-->This is for Method Overriding.
            {
                Console.WriteLine("I am the derived class");
            }
        }
        static void Main()
        {
            DerivedClass dc = new DerivedClass();
            dc.Print();
            BaseClass bc = new BaseClass();
            bc.Print();
            Console.ReadLine();
        }
    }
}

