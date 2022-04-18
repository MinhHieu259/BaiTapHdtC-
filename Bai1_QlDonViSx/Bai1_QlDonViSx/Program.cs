using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QlDonViSx
{
    class CanBo
    {
        public String name;
        public int age;
        public String gender;
        public String address;

        public CanBo(String name, int age, String gender, String address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }
        public string Name { get => name; set => name = value; }
        protected int Age { get => age; set => age = value; }
        protected string Gender { get => gender; set => gender = value; }
        protected string Address { get => address; set => address = value; }
    }

    class CongNhan : CanBo
    {
        public int level;
        public CongNhan(String name, int age, String gender, String address, int level) :base(name, age, gender, address)
        {
            this.level = level;
        }

        public int Level { get => level; set => level = value; }

        public override string ToString()
        {
            return "Cong nhan: " + "\n" +
                 "level=" + level + "\n" +
                 "name=" + name + "\n" +
                 "age=" + age + "\n" +
                 "gender=" + gender + "\n" +
                 "address=" + address + "\n"
                 ;
        }
    }

    class KySu : CanBo
    {
        public String branch;
        public KySu(String name, int age, String gender, String address, String branch) :base(name, age, gender, address)
        {
            this.Branch = branch;
        }

        public string Branch { get => branch; set => branch = value; }

        public override string ToString()
        {
            return "Ky Su: " + "\n" +
                "branch=" + branch  + "\n"+
                "name=" + name + "\n" +
                "age=" + age + "\n" +
                "gender=" + gender  + "\n" +
                "address=" + address  + "\n" 
                ;
        }
    }

    class NhanVien : CanBo
    {
        private String task;
        public NhanVien(String name, int age, String gender, String address, String task) : base(name, age, gender, address)
        {
            this.task = task;
        }

        public string Task { get => task; set => task = value; }

        public override string ToString()
        {
            return "Nhan Vien: " + "\n" +
                "task=" + task + "\n" +
                "name=" + name + "\n" +
                "age=" + age + "\n" +
                "gender=" + gender + "\n" +
                "address=" + address + "\n"
                ;
        }
    }

    class QLCB
    {
        private List<CanBo> canbos;

        public QLCB()
        {
            this.canbos = new List<CanBo>();
        }

        public void addCB(CanBo canbo)
        {
            this.canbos.Add(canbo);
        }

        public void searchOfficerByName(String name)
        {
            foreach(CanBo canbo in canbos)
            {
                if (canbo.name.Equals(name))
                {
                    Console.WriteLine(canbo.ToString());
                }
            }
        }

        public void showListInforOfficer()
        {
            if(this.canbos.Count > 0)
            {
                Console.WriteLine("------- Danh sach can bo -------");
                this.canbos.ForEach(o => Console.WriteLine(o.ToString()));
            }
            else
            {
                Console.WriteLine("------- Danh sach can bo trong -------" +"\n");
            }
            
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int line;
            String type;
           
            QLCB qlcb = new QLCB();

            while (true)
            {
                Console.WriteLine("Nhap lua chon cua ban:");
                Console.WriteLine("1. Them Can Bo");
                Console.WriteLine("2. Tim kiem Can Bo");
                Console.WriteLine("3. Danh sach Can Bo");
                Console.WriteLine("4. Thoat");
                line = int.Parse(Console.ReadLine());

                switch (line)
                {
                    case 1:
                        Console.WriteLine("a. Them Ky Su");
                        Console.WriteLine("b. Them Cong nhan");
                        Console.WriteLine("c. Them Nhan Vien");
                        type = Console.ReadLine();
                        switch (type)
                        {
                            case "a":
                                Console.Write("Nhap ten: ");
                                String name = Console.ReadLine();

                                Console.Write("Nhap tuoi: ");
                                int age = int.Parse(Console.ReadLine());

                                Console.Write("Nhap gioi tinh: ");
                                String gender = Console.ReadLine();

                                Console.Write("Nhap dia chi: ");
                                String address = Console.ReadLine();

                                Console.Write("Nhap nganh: ");
                                String branch = Console.ReadLine();
                                Console.WriteLine();

                                CanBo kysu = new KySu(name, age, gender, address, branch);
                                qlcb.addCB(kysu);
                               Console.WriteLine(kysu.ToString());
                                break;

                            case "b":
                                Console.Write("Nhap ten: ");
                                String namecn = Console.ReadLine();

                                Console.Write("Nhap tuoi: ");
                                int agecn = int.Parse(Console.ReadLine());

                                Console.Write("Nhap gioi tinh: ");
                                String gendercn = Console.ReadLine();

                                Console.Write("Nhap dia chi: ");
                                String addresscn = Console.ReadLine();

                                Console.Write("Nhap bac: ");
                                int level = int.Parse(Console.ReadLine());
                                Console.WriteLine();

                                CanBo congnhan = new CongNhan(namecn, agecn, gendercn, addresscn, level);
                                qlcb.addCB(congnhan);
                                Console.WriteLine(congnhan.ToString());
                                break;

                            case "c":
                                Console.Write("Nhap ten: ");
                                String namenv = Console.ReadLine();

                                Console.Write("Nhap tuoi: ");
                                int agenv = int.Parse(Console.ReadLine());

                                Console.Write("Nhap gioi tinh: ");
                                String gendernv = Console.ReadLine();

                                Console.Write("Nhap dia chi: ");
                                String addressnv = Console.ReadLine();

                                Console.Write("Nhap nganh: ");
                                String task = Console.ReadLine();
                                Console.WriteLine();

                                CanBo nhanvien = new NhanVien(namenv, agenv, gendernv, addressnv, task);
                                qlcb.addCB(nhanvien);
                                Console.WriteLine(nhanvien.ToString());
                                break;
                        }
                        break;

                    case 2:
                        Console.Write("Nhap ten can bo can tim kiem: ");
                        String search = Console.ReadLine();
                        qlcb.searchOfficerByName(search);
                        break;

                    case 3:
                        qlcb.showListInforOfficer();
                        break;
                    case 4:
                        {
                            return;
                        }
                    default:
                        Console.WriteLine("Khong hop le");
                        continue;
                }
            }
            Console.ReadKey();
        }   
    }
}
