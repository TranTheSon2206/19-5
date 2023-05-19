using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_5._1
{
    public class GoldStudent : Student
    {
        // Thuộc tính bổ sung đặc trưng cho sinh viên gold
        public int Bonus { get; set; } // Tiền thưởng

        // Phương thức hiển thị thông tin tiền thưởng
        public void ShowBonus()
        {
            Console.WriteLine("Bonus: " + Bonus);
        }
    }

}
