using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class StudentService : IStudent
    {
        private ArrayList students;

        public StudentService()
        {
            this.students = new ArrayList();
        }

        public StudentService(ArrayList students)
        {
            this.students = students;
        }

        public void Insert(Student st)
        {
            this.students.Add(st);
        }

        public void ShowAll()
        {
            foreach (Student student in this.students)
            {
                student.Display();
                Console.WriteLine("\n");
            }
        }

        public List<Student> Search(double n, double m)
        {
            List<Student> listData = new List<Student>();
            foreach (Student student in this.students)
            {
                double medium = (student.MathScore + student.PhyScore + student.CheScore) / 3;
                if (medium > n && medium < m)
                {
                    listData.Add(student);
                }
            }
            return listData;
        }
    }
}
