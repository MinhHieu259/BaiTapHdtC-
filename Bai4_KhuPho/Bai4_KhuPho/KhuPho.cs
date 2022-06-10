using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_KhuPho
{
    internal class KhuPho
    {
         List<HoGiaDinh> hoGiaDinh;

        public KhuPho()
        {
            this.hoGiaDinh = new List<HoGiaDinh>();
        }

        internal List<HoGiaDinh> HoGiaDinh { get => hoGiaDinh; set => hoGiaDinh = value; }

        public void addFamily(HoGiaDinh giaDinh)
        {
            this.HoGiaDinh.Add(giaDinh);
        }
    }
}
