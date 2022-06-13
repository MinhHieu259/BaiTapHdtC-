using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCuoiKy
{
    internal class RoomA : Room
    {
        public RoomA() : base("A", 500)
        {
           
        }

        public override string ToString()
        {
            return "RoomA{" +
               "category='" + Category + '\'' +
               ", price=" + Price +
               '}';
        }
    }
}
