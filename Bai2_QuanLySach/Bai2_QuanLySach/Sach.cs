using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLySach
{
    internal class Sach:TaiLieu
    {
        private String tenTacGia;
        private int soTrang;

        public Sach(String maTaiLieu, String nhaXuatBan, String soBanPhatHanh, String tenTacGia, int soTrang):base(maTaiLieu, nhaXuatBan, soBanPhatHanh)
        {
            this.tenTacGia = tenTacGia;
            this.soTrang = soTrang;
        }

        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }
        public override string ToString()
        {
            return "Sách: " + "\n" +
                 "Tên tác giả =" + tenTacGia + "\n" +
                 "Số trang=" + soTrang + "\n";
        }
    }
}
