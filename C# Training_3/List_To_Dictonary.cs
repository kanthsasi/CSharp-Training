using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class Customers
    {
        public int id { set; get; }
        public string name { set; get; }
        public int salary { set; get; }
    }
    internal class List_To_Dictonary
    {
        static void Main()
        {
            Customers c1 = new Customers() { id = 101, name = "Sanjiv Durai", salary = 40000 };
            Customers c2 = new Customers() { id = 102, name = "Manoj", salary = 35000 };
            Customers c3 = new Customers() { id = 103, name = "Venkat", salary = 38000 };

            List<Customers> customer = new List<Customers>();
            customer.Add(c1);
            customer.Add(c2);
            customer.Add(c3);
            Dictionary<int,Customers> dictionary= customer.ToDictionary(cust=>cust.id,cust=>cust);
            foreach(var cust in dictionary)
            {
                
                Console.WriteLine(cust.Key);
                Customers cus = cust.Value;
                Console.WriteLine("ID={0},Name={1},Salary={2}",cus.id,cus.name,cus.salary);
            
            }
            Console.ReadLine();
        }
    }
}