using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCuoiKy
{
    internal class Hotel
    {
        private List<Person> persons;

        public Hotel()
        {
            persons = new List<Person>();
        }

        public void add(Person person)
        {
            this.persons.Add(person);
        }

        public Boolean delete(String passport)
        {
            Person persona = this.persons.Find(p => p.Passport.Equals(passport));
            if (persona == null)
            {
                return false;
            }
            else
            {          
                this.persons.Remove(persona);
                return true;
            }
        }

        public int calculator(String passport)
        {
            Person person = this.persons.Find(p => p.Passport.Equals(passport));
            if (person == null)
            {
                return 0;
            }
            return person.Room.price * person.NumberRent;
        }

        public void show()
        {
            foreach(Person person in this.persons)
            {
                Console.WriteLine(person.ToString());
            }
        }

        public List<Person> tkTheoThang(String thang)
        {
             List<Person> persons = this.persons.FindAll(p => p.NgayThue.Month.Equals(thang));
            return persons;
        }
        public List<Person> tkTheoNam(String nam)
        {
             List<Person> persons = this.persons.FindAll(p => p.NgayThue.Year.Equals(nam));
            return persons;
        }

        public void maxMinRoom(String nam)
        {
            int soLanA = 0;
            int soLanB = 0;
            int soLanC = 0;
            String max, min;
            List<Person> persons = this.persons.FindAll(p => p.NgayThue.Year.Equals(nam));
            foreach(Person p in persons)
            {
                if(p.Room.category == "A")
                {
                    soLanA++;
                } else if(p.Room.category == "B")
                {
                    soLanB++;
                } else if(p.Room.category == "C")
                {
                    soLanC++;
                }
            }

            max = "A";
            if(soLanB > soLanA)
            {
                max = "B";
            } else if(soLanC > soLanB)
            {
                max = "C";
            }

            min = "A";
            if (soLanB < soLanA)
            {
                min = "B";
            }
            else if (soLanC < soLanB)
            {
                min = "C";
            }

            Console.WriteLine("Phòng đặt nhiều nhất trong năm "+nam+" là: "+max);
            Console.WriteLine("Phòng đặt ít nhất trong năm " + nam + " là: " + min);
        }

        public double tinhTongTienThang(String tgian)
        {
            double TongTien = 0;
            List<Person> persons = this.persons.FindAll(p => p.NgayThue.Month.Equals(tgian));
            foreach (Person p in persons)
            {
                TongTien += p.NumberRent * p.Room.price;
            }
            return TongTien;
        }

        public double tinhTongTienNam(String tgian)
        {
            double TongTien = 0;
            List<Person> persons = this.persons.FindAll(p => p.NgayThue.Year.Equals(tgian));
            foreach (Person p in persons)
            {
                TongTien += p.NumberRent * p.Room.price;
            }
            return TongTien;
        }
    }
}
