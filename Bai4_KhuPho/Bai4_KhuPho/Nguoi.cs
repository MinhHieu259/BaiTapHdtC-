using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_KhuPho
{
    internal class Nguoi
    {
        private String hoVaTen;
        private int tuoi;
        private String ngheNghiep;
        private String cmnd;

        public Nguoi(String hoVaTen, int tuoi, String ngheNghiep, String cmnd)
        {
            this.hoVaTen = hoVaTen;
            this.tuoi = tuoi;  
            this.ngheNghiep = ngheNghiep;
            this.cmnd = cmnd;
        }

        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }

        public override string ToString()
        {
            return "Thành viên: " +"\n"+
                "Tên: "+hoVaTen+ "\n" +
                "Tuổi: " +tuoi+ "\n" +
                "Nghề nghiệp: " +ngheNghiep+ "\n" +
                "CMND: " +cmnd;
        }

    }
}
