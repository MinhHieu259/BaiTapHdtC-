using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCuoiKy
{
    internal class Room
    {
        public String category;
        public int price;

        protected string Category { get => category; set => category = value; }
        protected int Price { get => price; set => price = value; }

        public Room(String category, int price)
        {
            this.category = category;
            this.price = price;
        }


    }
}
