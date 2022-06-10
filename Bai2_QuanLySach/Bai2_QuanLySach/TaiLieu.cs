using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLySach
{
    internal class TaiLieu
    {
        private String maTaiLieu;
        private String nhaXuatBan;
        private String soBanPhatHanh;

        public TaiLieu(String maTaiLieu, String nhaXuatBan, String soBanPhatHanh)
        {
            this.maTaiLieu = maTaiLieu;
            this.nhaXuatBan = nhaXuatBan;
            this.soBanPhatHanh = soBanPhatHanh;
           
        }


        public string MaTaiLieu { get => maTaiLieu; set => maTaiLieu = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
        public string SoBanPhatHanh { get => soBanPhatHanh; set => soBanPhatHanh = value; }
    }
}
