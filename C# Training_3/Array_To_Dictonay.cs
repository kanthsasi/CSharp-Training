using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Array_To_Dictonay
    {
        public class Customer
        {
            public int id;
            public string name;
            public int salary;
        }
        static void Main()
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer {id=101,name="Guru",salary=100000 };
            customer[1] = new Customer {id=102,name="Venkat",salary=200000 };
            customer[2] = new Customer {id=103,name="Kabilan",salary=300000 };
            //To Convert Array-Dictionary.
            Dictionary<int, Customer> dictonary = customer.ToDictionary(cust => cust.id, cust => cust);
            foreach (var cust in customer)
            {
                if (cust.salary > 200000)
                {
                    Console.WriteLine("Name:"+cust.name);
                }
            }
            Console.ReadLine();
            
        }
    }
}