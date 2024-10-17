using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Dictonary
    {
        public class Customer
        {
            public int ID;
            public string Name;
            public int Salary;
        }
        static void Main()
        {
            Customer customer1 = new Customer(){ID=101,Name="SasiKanth",Salary=5000000};  
            Customer customer2 = new Customer(){ID=102,Name="Sanjiv",Salary=200000};
            Customer customer3 = new Customer(){ID=103,Name="Manoj",Salary=300000};

            Dictionary<int, Customer> dictonarycustomer = new Dictionary<int, Customer>();

            dictonarycustomer.Add(customer1.ID,customer1);
            dictonarycustomer.Add(customer2.ID,customer2);
            dictonarycustomer.Add(customer3.ID,customer3);

            //This is for Indiviual.
            Customer customer101 = dictonarycustomer[101];
            Console.WriteLine("ID={0},Name={1},Salary={2}", customer101.ID, customer101.Name, customer101.Salary);

            //This is for totally.
            foreach (var customers in dictonarycustomer)
            {
                Console.WriteLine("Key=" + customers.Key);
                Customer cust = customers.Value;
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.ReadLine();
        }
    }
}
