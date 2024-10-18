using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class Student
    {
        public int id;
        public string name;
    }
    internal class FUNC_Delegate
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
        {
            new Student{id=1,name="Sasi"},
            new Student{id=2,name="Guru" },
            new Student{id=3,name="Vikram" }
        };
            //Func Delegate.
            Func<int, int,string> funcdelegate = (fnum, snum) => "SUM=" + (fnum + snum).ToString();
            string result = funcdelegate(10,20);
            Console.WriteLine(result);
            List<Student> stud = students.FindAll(s=>s.id>1);
            foreach (Student student in stud)
            {

                Console.WriteLine(student.id);
            }
            Console.ReadLine();

        }
    }
}
