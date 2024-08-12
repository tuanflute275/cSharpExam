using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class Student
    {
        private int id;
        private string name;
        private double mathScore;
        private double phyScore;
        private double cheScore;

        public Student(){}

        public Student(int id, string name, double mathScore, double phyScore, double cheScore)
        {
            this.Id = id;
            this.Name = name;
            this.MathScore = mathScore;
            this.PhyScore = phyScore;
            this.CheScore = cheScore;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double MathScore { get => mathScore; set => mathScore = value; }
        public double PhyScore { get => phyScore; set => phyScore = value; }
        public double CheScore { get => cheScore; set => cheScore = value; }

        public void InputData()
        {
            Console.WriteLine("Nhập vào id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào name: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập vào điểm toán: ");
            mathScore = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập vào điểm lý: ");
            phyScore = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập vào điểm hóa: ");
            cheScore = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Id       :  {id}");
            Console.WriteLine($"Name     :  {name}");
            Console.WriteLine($"MathScore:  {mathScore}");
            Console.WriteLine($"PhyScore :  {phyScore}");
            Console.WriteLine($"CheScore :  {cheScore}");
        }
    }
}
