using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class sortby:IComparer<Client>
    {
        public int Compare(Client x, Client y)
        {
            return x.salary.CompareTo(y.salary);
        }
    }
    public class Client:IComparable<Client>
    {
        public int id { set; get; }
        public string name { set; get; }
        public int salary { set; get; }

        public int CompareTo(Client other)
        {
            return this.id.CompareTo(other.id);
        }
    }
    internal class Array_To_List
    {
        static void Main()
        {
            Client c1 = new Client() {id=1,name="Sasi",salary=5000 };
            Client c2 = new Client() { id = 2, name = "Raja", salary = 6000 };
            Client c3 = new Client() { id = 3, name = "Kavin", salary = 7000 };

            Client[] clients = new Client[3];
            clients[0] = c1;
            clients[1] = c2;
            clients[2] = c3;
            
            List<Client> client=clients.ToList();
            Client c = client.Find(cus=>cus.salary>5000);
            Console.WriteLine("ID={0},Name={1},Salary={2}", c.id, c.name, c.salary);
            Console.WriteLine("-------------------------------------------------");
            List<Client> cs = client.FindAll(cus => cus.salary > 5000);
            
                foreach (Client ce in cs)
                {
                Console.WriteLine(ce.name);
                }
            Console.WriteLine("-------------------------------------------------");
            foreach (Client client1 in client)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}",client1.id,client1.name,client1.salary);
            }
            Console.ReadLine();
        }
    }
}
