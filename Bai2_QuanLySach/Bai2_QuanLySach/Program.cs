using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLySach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int line;
            String type;
            QuanLy<TaiLieu> quanLy = new QuanLy<TaiLieu>();
            quanLy.add(new Bao("TL01", "Nguyễn Minh Hiếu", "100", "25/5/2022"));
            quanLy.add(new TapChi("TL02", "Hiếu Nguyễn", "222", 1, "6"));
            
            while (true)
            {
               
                quanLy.title("Nhập lựa chọn của bạn:");
                quanLy.title("1. Thêm mới tài liệu");
                quanLy.title("2. Xoá tài liệu theo mã tài liệu");
                quanLy.title("3. Hiển thị thông tin về tài liệu");
                quanLy.title("4. Tìm kiếm tài liệu theo Sách, Tạp chí, Báo");
                quanLy.title("4. Thoát");
                line = int.Parse(Console.ReadLine());
                quanLy.title("--------------------");
                switch (line)
                {
                    case 1:
                        String maTaiLieu, nhaXuatBan, soBanPhatHanh;
                        quanLy.title("a.Thêm Báo");
                        quanLy.title("b.Thêm tạp chí");
                        quanLy.title("c.Thêm sách");
                        type = Console.ReadLine();
                        quanLy.title("--------------------");
                        switch (type)
                        {
                            case "a":
                                Console.Write("Nhập mã tài liệu: ");
                                 maTaiLieu = Console.ReadLine();

                                Console.WriteLine("Nhập nhà xuất bản");
                                nhaXuatBan = Console.ReadLine();

                                Console.WriteLine("Nhập số bản phát hành");
                                soBanPhatHanh = Console.ReadLine();

                                Console.WriteLine("Nhập ngày phát hành");
                                String ngayPhatHanh = Console.ReadLine();

                                TaiLieu bao = new Bao(maTaiLieu, nhaXuatBan, soBanPhatHanh, ngayPhatHanh);
                                quanLy.add(bao);
                                quanLy.title(bao.ToString());
                                break;

                            case "b":
                                Console.Write("Nhập mã tài liệu: ");
                                maTaiLieu = Console.ReadLine();

                                Console.WriteLine("Nhập nhà xuất bản");
                                nhaXuatBan = Console.ReadLine();

                                Console.WriteLine("Nhập số bản phát hành");
                                soBanPhatHanh = Console.ReadLine();

                                Console.WriteLine("Nhập số phát hành");
                                int soPhatHanh = int.Parse(Console.ReadLine());

                                Console.WriteLine("Nhập tháng phát hành");
                                String thangPhatHanh = Console.ReadLine();
                                TaiLieu tapChi = new TapChi(maTaiLieu, nhaXuatBan, soBanPhatHanh, soPhatHanh, thangPhatHanh);
                                quanLy.add(tapChi);
                                quanLy.title(tapChi.ToString());
                                break;

                            case "c":
                                Console.Write("Nhập mã tài liệu: ");
                                maTaiLieu = Console.ReadLine();

                                Console.WriteLine("Nhập nhà xuất bản");
                                nhaXuatBan = Console.ReadLine();

                                Console.WriteLine("Nhập số bản phát hành:");
                                soBanPhatHanh = Console.ReadLine();

                                Console.WriteLine("Nhập tên tác giả");
                                String tenTacGia = Console.ReadLine();

                                Console.WriteLine("Nhập số trang");
                                int soTrang = int.Parse(Console.ReadLine());
                                TaiLieu sach = new Sach(maTaiLieu, nhaXuatBan, soBanPhatHanh, tenTacGia, soTrang);
                                quanLy.add(sach);
                                quanLy.title(sach.ToString());
                                break;

                            default:

                                break;
                        }
                                break;
                    case 2:
                        Console.Write("Nhập mã tài liệu");
                        String keyMaTaiLieu = Console.ReadLine();
                        List<TaiLieu> taiLieu = quanLy.getLists().FindAll(p => p.MaTaiLieu == keyMaTaiLieu);
                       foreach (TaiLieu tl in taiLieu)
                        {
                            quanLy.getLists().Remove(tl);
                        }
                        quanLy.printf();
                        break;
                    case 3:
                        Console.WriteLine("Danh sách các tài liệu");
                        quanLy.printf();
                        break;
                    case 4:
                        quanLy.title("a.Tìm kiếm theo sách");
                        quanLy.title("b.Tìm kiếm theo tạp chí");
                        quanLy.title("c.Tìm kiếm theo sách");
                        Console.Write("Nhập loại tài liệu muốn tìm kiếm: ");
                        String loaiTl = Console.ReadLine();
                        String keySearch = "";
                        switch (loaiTl)
                        {
                            case "a":
                                Console.Write("Nhập mã tài liệu:");
                                keySearch = Console.ReadLine();
                                
                                List<TaiLieu> taiLieus = quanLy.getLists().FindAll(p => p.MaTaiLieu.Contains(keySearch) ? true : false);

                                foreach (TaiLieu tailieu in taiLieus)
                                {
                                    Console.WriteLine(tailieu.MaTaiLieu);
                                }
                                break;
                        }
                        break;
                }
            }
                Console.ReadKey();
        }
    }
}
