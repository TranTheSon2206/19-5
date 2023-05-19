using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_5._1
{
        public class Staff : People
        {
            // Các thuộc tính bổ sung đặc trưng cho nhân viên
            public decimal Salary { get; set; } // Lương

        // Các phương thức bổ sung đặc trưng cho nhân viên
            public void ShowSalary()
            {
            Console.WriteLine("Salary: " + Salary);
            }
        }

    }
    