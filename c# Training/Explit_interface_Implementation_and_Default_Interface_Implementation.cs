using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Explit_interface_Implementation_and_Default_Interface_Implementation
    {
        interface I1
        {
            void InterfaceMethod();
        }
        interface I2
        {
            void InterfaceMethod();
        }
        public class Program : I1,I2
        {
            void I1.InterfaceMethod()
            {
                Console.WriteLine("Interface 1");
            }
            public void InterfaceMethod()
            {
                Console.WriteLine("Interface 2");
            }
        }
        static void Main()
        {
            Program p = new Program();
            p.InterfaceMethod();//--->This is the way to call Default interface implementation. 
            ((I1)p).InterfaceMethod();//--->This is the way to call Explit interface implementation.
            Console.ReadLine();
            //We use explit interface implementation when both the interface methods have same declaration.
        }
    }
}
