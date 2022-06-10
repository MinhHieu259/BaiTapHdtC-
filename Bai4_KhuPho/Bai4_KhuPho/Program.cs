using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_KhuPho
{
    internal class Program
    {
        public static Nguoi nhapThanhVien(int tvThu)
        {
            Console.WriteLine("Nhập thành viên thứ {0}", tvThu);
            Console.Write("Nhập tên: ");
            String ten = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập nghề nghiệp: ");
            String nghe = Console.ReadLine();
            Console.Write("Nhập CMND: ");
            String cmnd = Console.ReadLine();
            Nguoi thanhvien = new Nguoi(ten, tuoi, nghe, cmnd);

            return thanhvien;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            KhuPho khupho = new KhuPho();
            Console.Write("Nhập số hộ dân: ");
            int soHo = int.Parse(Console.ReadLine());

            for(int i = 1; i <= soHo; i++)
            {
                Console.WriteLine("Nhập hộ dân số {0}: ",i);
                Console.Write("Nhập địa chỉ: ");
                String diaChi = Console.ReadLine();

                List<Nguoi> nguoi = new List<Nguoi>();
                Console.Write("Nhập số thành viên: ");
                int soTV = int.Parse(Console.ReadLine());

                for(int j = 1; j<= soTV; j++)
                {
                    Nguoi thanhVien = nhapThanhVien(j);
                    nguoi.Add(thanhVien);
                }

                khupho.addFamily(new HoGiaDinh(nguoi, diaChi));

                
            }
          foreach(HoGiaDinh gd in khupho.HoGiaDinh)
            {
                Console.WriteLine(gd.ToString());
            }
            Console.ReadKey();
        }
    }
}
