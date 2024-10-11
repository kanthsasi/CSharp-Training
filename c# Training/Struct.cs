using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal struct Struct
    {
        public struct Customer
        {
            private int _id;
            //Method.
            public void Output()
            {
                this._id = id;
                Console.WriteLine(this.id);
            }
            //Public properties.
            public int id
            {
                set
                {
                    this._id = value;
                }
                get
                {
                    return this._id;
                }
            }
            //Constructor.
            public Customer(int id)
            {
                this._id = id;
                
            }
        }
        static void Main()
        {
            Customer c = new Customer(101);
            c.Output();
            Console.WriteLine("cons:"+c.id);
            Console.ReadLine();

           
        }
    }
}
