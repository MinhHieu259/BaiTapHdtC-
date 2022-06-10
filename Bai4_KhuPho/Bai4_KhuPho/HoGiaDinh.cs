using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_KhuPho
{
    internal class HoGiaDinh
    {
        private List<Nguoi> nguoi;
        private String diaChi;

        public HoGiaDinh(List<Nguoi> nguoi, String diaChi)
        {
            this.nguoi = nguoi;
            this.diaChi = diaChi;
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        internal List<Nguoi> Nguoi { get => nguoi; set => nguoi = value; }

        public override string ToString()
        {
            return "Hộ gia đình: " +
                "Thành viên: " + string.Join(", ", nguoi) + "\n"+
                "Địa chỉ: "+diaChi;
        }
    }
}
