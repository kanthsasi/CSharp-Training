using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Properties_READ_WRITE
    {
        public class student
        {
            private int _id;
            private string _name;
            private int _passmark=35;
            public string City { get; set; }//---->Auto Implement Properties,Write in single line simply.
            //It was introduced in c# 3.0.

            public int id
            {
                set 
                {
                    if (value <= 0)
                    {
                        throw new Exception("ID should not be Zero or Minuz");
                    }
                    this._id = value;
                }
                get
                {
                    return this._id;  
                }
            }
            public string name
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("Name should not be NULL or EMPTY"); 
                    }
                    this._name = value;

                }
                get
                {
                    return string.IsNullOrEmpty(this._name) ? "no name" : this._name;
                }
            }
            public int passmark
            {
                get
                {
                    return this._passmark;
                }
            }

        }
        static void Main()
        {
            student s = new student();
            s.id = 101;
            s.name = "Sasi";
            s.City = "Chennai";
            Console.WriteLine("The Name is:"+s.name);
            Console.WriteLine("The passmark is:"+s.passmark);
            Console.WriteLine("The id is:"+s.id);
            Console.WriteLine(s.City);
            Console.ReadLine();
        }
    }
}
