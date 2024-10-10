using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Static_and_Instance_Classes
    {
        class Circle {
            static float _PI = 3.141F;//This is Static method
            int _Radius;//This is instance method
            //For call the static method we use a Class Name
            public Circle(int radius)
            {
                this._Radius = radius;
            }
            public float CalculateArea()
            {
                return Circle._PI * this._Radius * this._Radius;
            }
        }
        static void Main()
        {
            Circle c = new Circle(5);
            float Result=c.CalculateArea();
            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
