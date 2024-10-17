using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Dictionary_Example
    {
        public class Customer
        {
            public int id;
            public string name;
            public int salary;
        }
        static void Main()
        {
            Customer c1 = new Customer() { id = 1,name="Sasi",salary=100000 };
            Customer c2 = new Customer() {id=2,name="sanjiv",salary=20000 };
            Customer c3 = new Customer() { id = 3, name = "manoj", salary = 30000 };
            Customer c4 = new Customer() {id=4,name="Guru",salary=40000 };

            Dictionary<int, Customer> dictonary = new Dictionary<int, Customer>();
            dictonary.Add(c1.id,c1);
            dictonary.Add(c2.id,c2);
            dictonary.Add(c3.id,c3);
            
            if (!dictonary.ContainsKey(c4.id))
            {
                dictonary.Add(c4.id,c4);
            }
            if (dictonary.ContainsKey(4))
            {
              _= dictonary[4];
            }

            Customer customer1 = dictonary[4];
            Console.WriteLine("ID={0},Name={1},Salary={2}",customer1.id,customer1.name,customer1.salary);
         
            foreach (Customer value in dictonary.Values)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}", value.id, value.name, value.salary);
                Console.WriteLine("-----------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
