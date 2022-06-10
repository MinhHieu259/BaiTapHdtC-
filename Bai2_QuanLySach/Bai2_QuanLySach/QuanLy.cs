using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLySach
{
    internal class QuanLy<T>
    {
        private List<T> lists;

        public QuanLy()
        {
            this.lists = new List<T>();
        }
        public void add(T item)
        {
            lists.Add(item);
        }

        public void printf()
        {
            if (this.lists.Count > 0)
            {
                this.lists.ForEach(item => Console.WriteLine(item.ToString()));
            }
            else
            {
                Console.WriteLine("Danh sach trong");
            }
        }

        public List<T> getLists()
        {
            return this.lists;
        }

        public void title(String title)
        {
            Console.WriteLine(title);
        }

    }
}
