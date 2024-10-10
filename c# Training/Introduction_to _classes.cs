using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Introduction_to__classes
    {
        class Classes
        {
            //string f_name;
            //string l_name;
           /* public Classes(string fname, string lname)
            {
                this.f_name = fname;
                this.l_name = lname;
            }*/
            public void customer(string f_name,string l_name)
            {
                Console.WriteLine("Full name is:"+f_name+" "+l_name);
            }
            ~Classes()
            {
                //Destructor
                //Clean up code
            }
        }
        static void Main()
        {
            //Classes c = new Classes("Sasi","Kanth");
            Classes c = new Classes();
            c.customer("Sasi","Kanth");
            Classes c2 = new Classes();
            Console.ReadKey();
        }
    }
}
