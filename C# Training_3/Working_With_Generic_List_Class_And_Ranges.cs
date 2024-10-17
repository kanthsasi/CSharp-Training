using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class CustomerType
    {
        public int id;
        public string name;
        public int salary;
        public string Type;
    }
    
    internal class Working_With_Generic_List_Class_And_Ranges
    {
        static void Main() {
            CustomerType customer1 = new CustomerType() { id = 1, name = "Sasi", salary = 1000000,Type="Retail" };
            CustomerType customer2 = new CustomerType() { id = 2, name = "Abi", salary = 200000,Type="Retail" };
            CustomerType customer3 = new CustomerType() { id = 3, name = "Nidhish", salary = 300000,Type="Retail" };
            CustomerType customer4 = new CustomerType() { id = 4, name = "Rajesh", salary = 400000,Type="Corporate"};
            CustomerType customer5 = new CustomerType() { id = 5, name = "Kali", salary = 500000,Type="Corporate" };

            List < CustomerType > retailcustomer= new List<CustomerType>();
            retailcustomer.Add(customer1);
            retailcustomer.Add(customer2);
            retailcustomer.Add(customer3);
            List<CustomerType> corporatecustomer = new List<CustomerType>();
            corporatecustomer.Add(customer4);
            corporatecustomer.Add(customer5);

            retailcustomer.AddRange(corporatecustomer);
            foreach (CustomerType cs in retailcustomer)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2},Type={3}",cs.id,cs.name,cs.salary,cs.Type);
            }
            Console.WriteLine("---------------------------------------------------------");
            List<CustomerType> customerTypes = retailcustomer.GetRange(4,1);
            foreach (CustomerType cs in customerTypes)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2},Type={3}", cs.id, cs.name, cs.salary, cs.Type);
            }
            Console.WriteLine("---------------------------------------------------------");
            retailcustomer.InsertRange(3,corporatecustomer);
            foreach (CustomerType t in retailcustomer)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2},Type={3}", t.id, t.name, t.salary, t.Type);
            }
            Console.WriteLine("---------------------------------------------------------");
            retailcustomer.Remove(customer1);
            foreach (CustomerType t in retailcustomer)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2},Type={3}", t.id, t.name, t.salary, t.Type);
            }
            Console.WriteLine("---------------------------------------------------------");
            retailcustomer.RemoveAt(4);
            foreach (CustomerType t in retailcustomer)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2},Type={3}", t.id, t.name, t.salary, t.Type);
            }
            Console.WriteLine("---------------------------------------------------------");
            retailcustomer.RemoveAll(x=>x.Type=="Corporate");
            foreach (CustomerType cs in retailcustomer)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2},Type={3}", cs.id, cs.name, cs.salary, cs.Type);
            }
            Console.WriteLine("---------------------------------------------------------");
            retailcustomer.RemoveRange(0,1);
            foreach (CustomerType cs in retailcustomer)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2},Type={3}", cs.id, cs.name, cs.salary, cs.Type);
            }
            Console.ReadLine();
        }  

    }
}
