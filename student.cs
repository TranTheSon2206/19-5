using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_5._1
{
    public class Student : People
    {
        // Các thuộc tính bổ sung đặc trưng cho sinh viên
        public float Gpa { get; set; } // Điểm trung bình tích lũy

        //Các phương thức bổ sung của sinh viên
        public void GetGpa()
        {
            Console.WriteLine("Gpa: " + Gpa);
        }
    }

}
