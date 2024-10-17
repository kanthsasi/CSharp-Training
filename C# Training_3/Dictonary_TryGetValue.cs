using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Dictonary_TryGetValue
    {
        public class Customer
        {
            public int id;
            public string name;
            public int salary;
        }
        static void Main()
        {
            Customer c1 = new Customer() { id = 101, name = "Sanjiv Durai", salary = 40000 };
            Customer c2 = new Customer() { id = 102, name = "Manoj", salary = 35000 };
            Customer c3 = new Customer() { id = 103, name = "Venkat", salary = 38000 };
            Dictionary<int, Customer> dictonary = new Dictionary<int, Customer>();
            dictonary.Add(c1.id,c1);
            dictonary.Add(c2.id,c2);
            dictonary.Add(c3.id,c3);
            dictonary.Remove(101);//------>This is Remove Key Word in Dictonary.
            //dictonary.Clear(); will remove all the functions in the Dictonary.
            Customer cust;
            if (dictonary.TryGetValue(101, out cust))
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.id, cust.name, cust.salary);
            }
            else
            {
                Console.WriteLine("The Key is Not Found");
            }
            Console.ReadLine();
            
            
        }
    }
}
