using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    //Regular Class - Regular class are classes which can be instantiated.

    class RegularClass
    {
        private string name;
        //Constructor
        public RegularClass(string name)
        {
            this.name = name;
        }
        //genral method
        public void Print()
        {
            Console.WriteLine("General class");

        }
    }

    //Static Class - Static classes can not be instantiated and contains only Static members.
    public static class StaticClass {
     
        public static void Display() {
            Console.WriteLine("staticclass");

        }
    }

    ///<summary>
    ///Abstractclass
    ///cannot be instantiated  and is intended to be a base class.
    /// we need to implement all methods present in base class in the child class.
     /// we use overriding to achieve abstraction.
     ///No implementation for abstract methods.///</summary>
     
    public abstract class AbstractClass
    {
        public abstract void AbstractMethod();
    }

    //DerivedClass inheriting from AbstractClass
    public class DerivedClass : AbstractClass {
        //Implementing all the abstract methods
        public override void AbstractMethod()
        {
            Console.WriteLine("implemented in derived class");
        }
    }

    //Sealed class - Sealed class cannot be inherited.
    public sealed class SealedClass
    {
        public void Show()
        {
            Console.WriteLine("no inheritance");
        }

    }

    // Partial Class
    // This is a partial class. It can be split into multiple files.
    public partial class PartialClass
    {
        // Method in part 1
        public void Part1Method()
        {
            Console.WriteLine("Hello from Partial Class Part 1!");
        }
    }

    // Partial Class (Part 2)
    public partial class PartialClass
    {
        // Method in part 2
        public void Part2Method()
        {
            Console.WriteLine("Hello from Partial Class Part 2!");
        }
    //Nested Class
    //defined within another class
    public class OuterClass
        {
            public class InnerClass
            {
                public void Show()
                {
                    Console.WriteLine("hello");
                }
            }
        }

        class Program
        {
            private static void Main()
            {
                //Regular class
                RegularClass regular = new RegularClass("Regular class");
                regular.Print();

                //static class
                StaticClass.Display();

                //Abstract class
                AbstractClass abstractclass = new DerivedClass();
                abstractclass.AbstractMethod();

                //sealed class
                SealedClass sealedclass = new SealedClass();
                sealedclass.Show();

                //partialclass
                PartialClass partial = new PartialClass();
                partial.Part1Method();
                partial.Part2Method();

                //Nested class
                OuterClass.InnerClass nested = new OuterClass.InnerClass();
                nested.Show();
                
            }
        }
}




}
