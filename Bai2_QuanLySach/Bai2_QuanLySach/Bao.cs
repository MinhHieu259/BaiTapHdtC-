using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLySach
{
    internal class Bao:TaiLieu
    {
        private String ngayPhatHanh;

        public Bao(String maTaiLieu, String nhaXuatBan, String soBanPhatHanh, String ngayPhatHanh):base(maTaiLieu, nhaXuatBan, soBanPhatHanh)
        {
            this.ngayPhatHanh = ngayPhatHanh;
        }

        public string NgayPhatHanh { get => ngayPhatHanh; set => ngayPhatHanh = value; }

        public override string ToString()
        {
            return "Báo: " + "\n" +
                "Mã tài liệu=" + MaTaiLieu + "\n"+
                "Nhà xuất bản=" + NhaXuatBan + "\n"+
                "Số bản phát hành=" + SoBanPhatHanh + "\n" +
                 "Ngày phát hành=" + ngayPhatHanh + "\n";
        }
    }
}
