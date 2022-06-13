using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCuoiKy
{
    internal class RoomB : Room
    {
        public RoomB() : base("B", 300)
        {

        }

        public override string ToString()
        {
            return "RoomB{" +
               "category='" + Category + '\'' +
               ", price=" + Price +
               '}';
        }
    }
}
