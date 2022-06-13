using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCuoiKy
{
    internal class RoomC :Room
    {
        public RoomC() : base("C", 100)
        {

        }

        public override string ToString()
        {
            return "RoomC{" +
               "category='" + Category + '\'' +
               ", price=" + Price +
               '}';
        }
    }
}
