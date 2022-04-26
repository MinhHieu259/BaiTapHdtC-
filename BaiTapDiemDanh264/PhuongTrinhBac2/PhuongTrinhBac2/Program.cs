using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    internal class Program
    {
        class ptBacHai
        {
            private float a;
            private float b;
            private float c;

            public ptBacHai()
            {
                
            }
            public ptBacHai(float a, float b, float c)
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }

            public float A { get => a; set => a = value; }
            public float B { get => b; set => b = value; }
            public float C { get => c; set => c = value; }

            public static float delTa(float a, float b, float c)
            {
                float delta = b * b - 4 * a *c;
                return delta;
            }

            public static void tinhBac2(float a, float b, float c)
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Phuong trinh vo nghiem!");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh co mot nghiem: x = {0}", (-c / b));
                    }
                    return;
                }
                // tinh delta
                float delta = delTa(a, b, c);
                float x1;
                float x2;
                // tinh nghiem
                if (delta > 0)
                {
                    x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("Phuong trinh co 2 nghiem la: x1 = %f va x2 = %f", x1, x2);
                }
                else if (delta == 0)
                {
                    x1 = (-b / (2 * a));
                    Console.WriteLine("Phong trinh co nghiem kep: x1 = x2 = %f", x1);
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a:");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b:");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap c:");
            float c = float.Parse(Console.ReadLine());

            ptBacHai.tinhBac2(a, b, c);
            Console.ReadKey();
        }
    }
}
