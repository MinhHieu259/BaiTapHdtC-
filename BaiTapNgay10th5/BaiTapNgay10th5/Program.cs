using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay10th5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr_120 = new int[10];
            int[,] mode_120 = new int[10,2];
            Console.WriteLine("Nhap 10 so nguyen");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("Gia tri " + l + " la :"+  arr_120[l]);
            }
            //tim gia tri lon nhat va nho nhat 
     
            //sap xep mang de tim gia tri lon nhat va nho nhat 
            for (int i = 0; i < 10; i++)
                for (int j = 9; j > i; j--)
                    if (arr_120[j] < arr_120[j - 1])
                    {
                        int temp = arr_120[j];
                        arr_120[j] = arr_120[j - 1];
                        arr_120[j - 1] = temp;
                    }

            Console.WriteLine("Gia tri lon nhat=" + arr_120[9] + "\nGia tri nho nhat="+ arr_120[0]);
            
            //khoi tao mang 2 chieu de sap xep tan suat va gia tri
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 10; j++)  
                    mode_120[j,i] = 0;
            mode_120[0,0] = 1;
            //tim tan suat 
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (arr_120[i] == arr_120[j + 1]) { 
                        ++mode_120[i,0]; 
                        mode_120[i,1] = arr_120[i]; 
                    }
            //tim so lan suat hien nhieu nhat 
            int max_120;
            int k = 0;
            max_120 = mode_120[0,0];
            for (int j = 0; j < 10; j++)
                if (max_120 < mode_120[j,0]) { max_120 = mode_120[j,0]; k = j; }
            //in ket qua 
           Console.WriteLine("Gia tri xuat hien nhieu nhat la:" + mode_120[k,1]);
            Console.WriteLine("Xuat hien " + max_120 + " lan.");
            Console.ReadKey();  
        }
        
    }
    
}
