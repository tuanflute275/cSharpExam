using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public interface IStudent
    {
        void Insert(Student st);
        void ShowAll();
        List<Student> Search(double n, double m);
    }
}
