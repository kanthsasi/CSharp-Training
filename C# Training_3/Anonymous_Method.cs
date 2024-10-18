using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Anonymous_Method
    {

        public class Student
        {
            public int id;
            public string name;
        }
        
        static void Main()
        {
            Student student1 = new Student() {id=1,name="Sasi" };
            Student student2 = new Student() {id=2,name="Sanjiv" };
            Student student3 = new Student() {id=3,name="Manoj" };

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            //Below method is Anonymous Method.
            Student stud = students.Find(delegate (Student st) { return st.name == "Sasi"; });
            Console.WriteLine("Id={0},Name={1}", stud.id, stud.name);
            Console.WriteLine("---------------------------------------------");
            List<Student> studs= students.FindAll(x => x.id > 2);//-->Lambda Expression.
            foreach(Student stu in studs)
            {
                Console.WriteLine("Name={0}", stu.name);
            }
            Console.WriteLine("---------------------------------------------");
            //Below method is a Func Delegate.
            IEnumerable<string> name = students.Select(stu=>"Name:"+stu.name);
            foreach (string names in name)
            {
                Console.WriteLine(names);
            }
           
            Console.ReadLine();
        }
    }
}
