using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLySach
{
    internal class TapChi:TaiLieu
    {
        private int soPhatHanh;
        private String thangPhatHanh;

        public TapChi(String maTaiLieu, String nhaXuatBan, String soBanPhatHanh, int soPhatHanh , String thangPhatHanh): base(maTaiLieu, nhaXuatBan, soBanPhatHanh)
        {
            this.thangPhatHanh = thangPhatHanh;
            this.soPhatHanh= soPhatHanh;
        }

        public int SoPhatHanh { get => soPhatHanh; set => soPhatHanh = value; }
        public string ThangPhatHanh { get => thangPhatHanh; set => thangPhatHanh = value; }
        public override string ToString()
        {
            return "Tạp chí: " + "\n" +
                 "Số phát hành=" + soPhatHanh + "\n"+
                 "Tháng phát hành=" + thangPhatHanh + "\n";
        }
    }
}
