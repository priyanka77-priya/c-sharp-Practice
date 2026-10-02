using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    
        public interface IInterface1
        {
            //All are Abstract Methods and they dont need any implementation
            //By default all the methods are public and abstract so no need to mention them as public / abstract
            //We can not use members or contsructors in it
            void Add(int num1, int num2);

        }
        public interface IInterface2
        {
            void Sub(int num1, int num2);
        }
        public class Dog : IInterface1
        {
            public void Add(int num1, int num2)
            {
                Console.WriteLine($"{num1} and {num2} sum is {num1 + num2}");
            }

        }
        public  class Cat : IInterface2, IInterface1
        {
            public void Sub(int num1, int num2)
            {
                Console.WriteLine($"{num1} and {num2} sub is {num1 - num2}");
            }
            public void Add(int num1, int num2)
            {
                Console.WriteLine($"{num1} and {num2} sum is {num1 + num2}");
            }
        }


    class Program
    {
        public static void Main()
        {
            Dog obj1 = new Dog();
            obj1.Add(1, 2);
            Cat obj2 = new Cat();
            obj2.Sub(1, 2);

        }

    }
}

