using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Inheritance_base_keyword
    {
        public class ParentClass {
            public void ParentClasss()
            {
                Console.WriteLine("ParentClass Constructor Called");
            }
            public ParentClass(string meassage)
            {
                Console.WriteLine(meassage);
            }
        }
        public class ChildClass : ParentClass{
            public ChildClass() : base("Derived class controlling parent class")
            {
                //This base will usable for void methods only not for constructors.
                //base.ParentClasss();
                Console.WriteLine("ChildClass Constructor Called");
            }
        }
        static void Main()
        {
            ChildClass cc = new ChildClass();
            cc.ParentClasss();
            Console.ReadLine();
        }
    }
}
