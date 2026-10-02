using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment
{
    class Bird

    {

        public void Eat()
        {
            Console.WriteLine("printt eat");
        }
        public void Chirp()
        {
            Console.WriteLine("print chirp");
        }

    }
    class FlyingBird : Bird
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

    }
    class NonflyingBird : Bird
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly");
        }
    }
    class Ostritch : NonflyingBird
    {
        public void Name()
        {
            Console.WriteLine("Ostrich");
        }
    }
    class Peacock : FlyingBird
    {
        public void Name()
        {
            Console.WriteLine("peacock");
        }
    }
    class Sparrow : FlyingBird
    {
        public void Name()
        {
            Console.WriteLine("sparrow");
        }
    }

    class Crow : FlyingBird
    {
        public void Name()
        {
            Console.WriteLine("crow");
        }
    }
    class Kiwi : NonflyingBird
    {
        public void Name()
        {
            Console.WriteLine("Kiwi");
        }
    }
    class Inheritance
    {

        public static void Main()
        {
            Ostritch ostritch = new Ostritch();
            ostritch.Name();
            ostritch.Eat();
            ostritch.Chirp();
            ostritch.Fly();

            Peacock peacock = new Peacock();
            peacock.Name();
            peacock.Chirp();
            peacock.Eat();
            peacock.Fly();

            Sparrow sparrow = new Sparrow();
            sparrow.Chirp();
            sparrow.Name();
            sparrow.Fly();
            sparrow.Eat();

            Crow crow = new Crow();
            crow.Chirp();
            crow.Name();
            crow.Eat();
            crow.Fly();


            Kiwi kiwi = new Kiwi();
            kiwi.Name();
            kiwi.Eat();
            kiwi.Chirp();
            kiwi.Fly();
        }

    }


    // Hierarchical Inheritance 
    class Program
    {
        static void Main()
        {
            Ostritch ostrich = new Ostritch();
            Peacock peacock = new Peacock();
            Sparrow sparrow = new Sparrow();
            Crow crow = new Crow();
            Kiwi kiwi = new Kiwi();

            ostrich.Eat();  // Inherited from Bird
            peacock.Chirp();  // Inherited from Bird
            sparrow.Fly();  // Inherited from FlyingBird
            crow.Fly();  // Inherited from FlyingBird
            kiwi.Fly();  // Inherited from NonFlyingBird
        }
    }

    // Multilevel Inheritance 
    class SuperBird : Bird
    {
        public void SuperChirp()
        {
            Console.WriteLine("Super chirp!");
        }
    }

    class SuperFlyingBird : SuperBird
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }

    class SuperNonFlyingBird : SuperBird
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly");
        }
    }

    class Program1
    {
        static void Main()
        {
            SuperFlyingBird superSparrow = new SuperFlyingBird();
            SuperNonFlyingBird superOstrich = new SuperNonFlyingBird();

            superSparrow.SuperChirp();  // Inherited from SuperBird
            superSparrow.Fly();  // Inherited from SuperFlyingBird
            superOstrich.SuperChirp();  // Inherited from SuperBird
            superOstrich.Fly();  // Inherited from SuperNonFlyingBird
        }
    }

    // Multiple Inheritance
    interface IFlyable
    {
        void Fly();
    }

    class SpecialBird : FlyingBird, IFlyable
    {
        public void SpecialAbility()
        {
            Console.WriteLine("I have a special ability!");
        }

        // Implementing the Fly method from IFlyable
        void IFlyable.Fly()
        {
            Console.WriteLine("I can fly");
        }
    }

    class Program2
    {
        static void Main()
        {
            SpecialBird specialBird = new SpecialBird();
            specialBird.Eat();  // Inherited from Bird
            ((IFlyable)specialBird).Fly();  // Inherited from IFlyable
            specialBird.SpecialAbility();
        }
    }





}





