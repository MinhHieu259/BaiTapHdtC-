using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat
{
    internal class Program
    {
       abstract class Animal
        {
            public abstract void eat();

            public abstract void makeSound();
            
        }

        class Cat : Animal
        {
            public override void eat()
            {
                throw new NotImplementedException();
            }

            public override void makeSound()
            {
                throw new NotImplementedException();
            }

            public void run()
            {
                Console.WriteLine("Meo chay");
            }
        }

        class Bird : Animal
        {
            public override void eat()
            {
                throw new NotImplementedException();
            }

            public void fly()
            {
                Console.WriteLine("Chim Bay");
            }

            public override void makeSound()
            {
                throw new NotImplementedException();
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
