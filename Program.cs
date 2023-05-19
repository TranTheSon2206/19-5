using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_5._1
{
    class Program
    {
        static List<People> peopleList = new List<People>(); // Danh sách các đối tượng People

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("1. Thêm thông tin nguoi (People) mới");
                Console.WriteLine("2. Thêm sinh viên ");
                Console.WriteLine("3. Thêm nhân viên (Staff)");
                Console.WriteLine("4. Thêm quảnn lý (Manager)");
                Console.WriteLine("5. Show thông tin theo ID");
                Console.WriteLine("6. Thoát");
                Console.Write("Vui lòng chọn một lựa chọn (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewPeople();
                        break;
                    case "2":
                        AddNewStudent();
                        break;
                    case "3":
                        AddNewStaff();
                        break;
                    case "4":
                        AddNewManager();
                        break;
                    case "5":
                        ShowInfoById();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
        }

        static void AddNewPeople()
        {
            Console.WriteLine("\n----- THÊM THÔNG TIN NGƯỜI (PEOPLE) MỚI -----");
            People people = new People();
            Console.Write("ID: ");
            people.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            people.Name = Console.ReadLine();
            Console.Write("Email: ");
            people.Email = Console.ReadLine();

            peopleList.Add(people);
            Console.WriteLine("Thêm thông tin người thành công!");
        }

        static void AddNewStudent()
        {
            Console.WriteLine("\n----- THÊM SINH VIÊN MỚI -----");
            Student student = new Student();
            Console.Write("ID: ");
            student.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Email: ");
            student.Email = Console.ReadLine();        

            peopleList.Add(student);
            Console.WriteLine("Thêm sinh viên thành công!");
        }

        static void AddNewStaff()
        {
            Console.WriteLine("\n----- THÊM NHÂN VIÊN (STAFF) MỚI -----");
            Staff staff = new Staff();
            Console.Write("ID: ");
            staff.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            staff.Name = Console.ReadLine();
            Console.Write("Email: ");
            staff.Email = Console.ReadLine();          
            Console.Write("Salary: ");
            staff.Salary = decimal.Parse(Console.ReadLine());

            peopleList.Add(staff);
            Console.WriteLine("Thêm nhân viên thành công!");
        }

        static void AddNewManager()
        {
            Console.WriteLine("\n----- THÊM QUẢN LÝ (MANAGER) MỚI -----");
            Manager manager = new Manager();
            Console.Write("ID: ");
            manager.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            manager.Name = Console.ReadLine();
            Console.Write("Email: ");
            manager.Email = Console.ReadLine();
            Console.Write("Salary: ");
            manager.Salary = decimal.Parse(Console.ReadLine());
            Console.Write("Level: ");
            manager.Level = Console.ReadLine();

            peopleList.Add(manager);
            Console.WriteLine("Thêm quản lý thành công!");
        }

        static void ShowInfoById()
        {
            Console.WriteLine("\n----- HIỂN THỊ THÔNG TIN THEO ID -----");
            Console.Write("Nhập ID cần tìm: ");
            int find = int.Parse(Console.ReadLine());

            People foundPeople = peopleList.FirstOrDefault(p => p.Id == find);
            if (foundPeople != null)
            {
                foundPeople.ShowInfo();
            }
            else
            {
                Console.WriteLine("Không tìm thấy người có ID tương ứng.");
            }
        }

    }


}
