using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDaHinh
{
    class DaGiac
    {
        public int soCanh;
        private int[] a;
        public int SoCanh { get => soCanh; set => soCanh = value; }
        public int[] A { get => a; set => a = value; }

        public DaGiac(int soCanh, int a)
        {
            this.soCanh = 0;
            this.A = null;
        }
        protected void nhap()
        {
            do
            {
                Console.Write("Nhap vao so canh: ");
                this.soCanh = int.Parse(Console.ReadLine());

            } while (this.soCanh <= 2);
            for (int i = 0; i < this.soCanh; i++)
            {
                Console.Write("Nhap canh thu " + (i + 1) + " :");
                this.A[i] = int.Parse(Console.ReadLine());
            }
        }

        protected void xuatDaGiac()
        {
            Console.WriteLine("Do dai cac canh lan luot la: ");
            for (int i = 0; i < this.soCanh; i++)
            {
                if (i < (this.soCanh - 1))
                {
                    Console.WriteLine(this.a[i] + "\t  \t");
                }
                else
                {
                    Console.WriteLine(this.a[i]);
                }
            }
        }
        public override string ToString()
        {
            return "DaGiac{" +
                 "soCanh=" + soCanh +
                 '}';
        }
    }

    class TamGiac : DaGiac
    {
        public TamGiac(int soCanh, int a) : base(soCanh, a)
        {
            this.soCanh = 0;
            this.A = null;
        }

        public void nhap()
        {
            do
            {
                Console.Write("Nhap so canh cho tam giac: ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Nhap canh thu " + (i + 1) + " :");
                    this.A[i] = int.Parse(Console.ReadLine());
                }
            } while ((A[0] + A[1]) <= A[2] || (A[1] + A[2]) <= A[0] || (A[0] + A[2]) <= A[1]);
        }

        public void xuat()
        {
            xuatDaGiac();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //DaGiac tg = new TamGiac();

            Console.ReadKey();
        }

    }
}
