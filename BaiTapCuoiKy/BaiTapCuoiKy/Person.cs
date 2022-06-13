using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCuoiKy
{
    internal class Person
    {
        private String name;
        private int age;
        private String passport;
        private Room room;
        private int numberRent;
        private DateTime ngayThue;

        public Person(String name, int age, String passport, Room room, int numberRent, DateTime ngayThue)
        {
            this.name = name;
            this.age = age;
            this.passport = passport;
            this.numberRent = numberRent;
            this.room = room;
            this.NgayThue = ngayThue;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Passport { get => passport; set => passport = value; }
        public int NumberRent { get => numberRent; set => numberRent = value; }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        internal Room Room { get => room; set => room = value; }

        public override string ToString()
        {
            return "Person{" +
                "name='" + name + '\'' +
                ", age=" + age +
                ", passport='" + passport + '\'' + room.ToString() +
                 ", ngay Thue=" + ngayThue +
                '}';
        }
    }
}
