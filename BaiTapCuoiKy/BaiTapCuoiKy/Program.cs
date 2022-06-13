using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCuoiKy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Hotel hotel = new Hotel();
            while (true)
            {
                Console.WriteLine("Nhập lựa chọn của bạn");
                Console.WriteLine("1. Thêm khách");
                Console.WriteLine("2. Xoá khách theo số chứng minh");
                Console.WriteLine("3. Tính tiền thuê theo CMND");
                Console.WriteLine("4. Thống kê thông tin thuê");
                Console.WriteLine("5. Phòng được đặt nhiều nhất, ít nhất");
                Console.WriteLine("6. Tính tổng tiền thuê theo tháng, quý, năm");
                Console.WriteLine("7. Hiển thị danh sách khách hàng");
                Console.WriteLine("8. Thoát");

                Console.Write("Nhập lựa chọn của bạn: ");
                String line = Console.ReadLine();

                switch (line)
                {
                    case "1":
                        Console.Write("Nhập tên: ");
                        String name = Console.ReadLine();
                        Console.Write("Nhập tuổi: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Nhập CMND: ");
                        String passport = Console.ReadLine();
                        Console.WriteLine("Nhập loại phòng cần thuê");
                        Console.WriteLine("a. Phòng loại A");
                        Console.WriteLine("b. Phòng lạoi B");
                        Console.WriteLine("c. Phòng loại c");
                        String choise = Console.ReadLine();

                        Room room;
                        if (choise == "a")
                        {
                            room = new RoomA();
                        }
                        else if (choise == "b")
                        {
                            room = new RoomB();
                        }
                        else if (choise == "c")
                        {
                            room = new RoomC();
                        }
                        else
                        {
                            continue;
                        }

                        Console.Write("Nhập số ngày thuê: ");
                        int numberRent = int.Parse(Console.ReadLine());
                        Console.Write("Nhập ngày bắt đầu thuê: ");
                        DateTime ngayThue = DateTime.Parse(Console.ReadLine());


                        Person person = new Person(name, age, passport, room, numberRent, ngayThue);
                        hotel.add(person);
                        break;

                        case "2":
                        Console.Write("Nhập số CMND:");
                        String ppDelete = Console.ReadLine();
                        hotel.delete(ppDelete);
                        break;

                    case "3":
                        Console.Write("Nhập số CMND:");
                        String ppPrice = Console.ReadLine();
                        Console.WriteLine("Tiền thuê: {0}", hotel.calculator(ppPrice));
                        break;
                    case "4":
                        Console.WriteLine("Chọn kiểu thống kê: ");
                        Console.WriteLine("t. Thống kê theo tháng");
                        Console.WriteLine("q. Thống kê theo quý");
                        Console.WriteLine("n. Thống kê theo năm");
                        Console.Write("Nhập kiểu thống kê: ");
                        String kieuTk = Console.ReadLine();
                        switch (kieuTk)
                        {
                            case "t":
                                Console.Write("Nhập tháng: ");
                                String thang = Console.ReadLine();
                                List<Person> personThang = hotel.tkTheoThang(thang);
                                foreach (Person persont in personThang)
                                {
                                    Console.WriteLine(persont.ToString());
                                }
                                break;
                            case "q":
                                Console.WriteLine("ABC");
                                break;
                            case "n":
                                Console.Write("Nhập năm: ");
                                String nam = Console.ReadLine();
                                List<Person> personNam = hotel.tkTheoNam(nam);
                                foreach (Person persont in personNam)
                                {
                                    Console.WriteLine(persont.ToString());
                                }
                                break;
                        }
                        break;

                    case "5":
                        Console.Write("Nhập vào năm cần kiểm tra: ");
                        String namMaxMin = Console.ReadLine();
                        hotel.maxMinRoom(namMaxMin);
                        break;
                    case "6":
                        Console.WriteLine("Chọn thời gian để tính tiền");
                        Console.WriteLine("t. Theo tháng");
                        Console.WriteLine("q. Theo quý");
                        Console.WriteLine("n. Theo năm");
                        Console.Write("Nhập thời gian: ");
                        String tgianTien = Console.ReadLine();
                        switch (tgianTien)
                        {
                            case "t":
                                Console.Write("Nhập tháng: ");
                                String thangTien = Console.ReadLine();
                               double tongTien = hotel.tinhTongTienThang(thangTien);
                                Console.WriteLine("Tổng tiền: {0}", tongTien);
                                break;

                            case "q":
                                Console.WriteLine("ABC");
                                break;

                            case "n":
                                Console.Write("Nhập năm: ");
                                String namTien = Console.ReadLine();
                                double tongTienNam = hotel.tinhTongTienNam(namTien);
                                Console.WriteLine("Tổng tiền: {0}", tongTienNam);
                                break;
                        }
                        break;
                    case "7":
                        hotel.show();
                        break;

                        default:
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
