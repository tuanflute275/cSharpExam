using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            // vẽ hình cn: CSharp/Ex3/Bai1.cs at master · thantrieu/CSharp
            int choice = 0;
            Console.OutputEncoding = Encoding.UTF8;
            StudentService studentService = new StudentService();
            do
            {
                Console.WriteLine("Nhập vào lựa chọn của bạn: ");
                Console.WriteLine("1. Nhập sữ liệu cho sinh viên");
                Console.WriteLine("2. Hiển thị toàn bộ sinh viên");
                Console.WriteLine("3. Tìm kiếm và hiển thị sinh viên");
                Console.WriteLine("4. Thoát");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Student student = new Student();
                        student.InputData();
                        studentService.Insert(student);
                        break;
                    case 2:
                        Console.WriteLine("======== Danh sách sinh viên =======");
                        studentService.ShowAll();
                        break;
                    case 3:
                        Console.WriteLine("Nhập điểm trung binh trong khoang tu n đến m: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int m = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Danh sách sau khi tìm kiếm là: ");
                        foreach (Student itemSt in studentService.Search(n, m))
                        {
                            itemSt.Display();
                        };
                        break;
                }


            } while (choice != 4);
        }
    }
}
