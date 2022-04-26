using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat
{
    internal class Program
    {
        class Animal
        {
            public  void eat()
            {
                Console.WriteLine("Dong vat an");
            }

            public  void makeSound()
            {
                Console.WriteLine("Dong vat keu");
            }
        }

        class Cat : Animal
        {
            public  void run()
            {
                Console.WriteLine("Meo chay");
            }
        }

        class Bird : Animal
        {
            public  void fly()
            {
                Console.WriteLine("Chim Bay");
            }
        }
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.run();

            Bird bird = new Bird();
            bird.fly();

            Console.ReadKey();
        }
    }
}
