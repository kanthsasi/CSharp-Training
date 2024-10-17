using System;
using System.Reflection;

namespace CSharp_Training3
{
    internal class Reflection
    {
        public class Customer
        {
            //Properties:
            public int ID{ get; set; }
            public string Name { get; set; }
            public double num { get; set; }
            //-----------------------------------------//
            public Customer(int ID,string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }
            public Customer()
            {
                this.ID = -1;
                this.Name = string.Empty;
            }
            public void PrintID()
            {
                Console.WriteLine("ID:"+this.ID);
            }
            public void PrintName()
            {
                Console.WriteLine("Name:"+this.Name);
            }
        }
        static void Main()
        {
           /* Customer c=new Customer();
            Type T = c.GetType();*/
            Type T = typeof(Customer);
            Console.WriteLine("FullName:"+T.FullName);
            Console.WriteLine("Just The Name:"+T.Name);
            Console.WriteLine("Just The Namespace:"+ T.Namespace);
            Console.WriteLine();

            Console.WriteLine("Properties of Customer");
            PropertyInfo[] properties=T.GetProperties();
            foreach (PropertyInfo propertie in properties)
            {
                Console.WriteLine(propertie.PropertyType.Name+" "+propertie.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methods=T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+" "+method.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Constructors in Customer Class");
            ConstructorInfo[] constructors=T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            Console.ReadLine();
        }
    }
}
