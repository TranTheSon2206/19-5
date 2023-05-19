using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_5._1
{
    public class Manager : Staff
    {
        // Thuộc tính bổ sung đặc trưng cho quản lý
        public string Level { get; set; } // Cấp bậc

        // Phương thức hiển thị thông tin cấp bậc của quản lý
        public void ShowLevel()
        {
            Console.WriteLine("Level: ",Level);
        }
    }
}
