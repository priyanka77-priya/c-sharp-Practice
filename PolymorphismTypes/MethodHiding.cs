using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTypes
{
    public class MethodHiding
    {
        public void Print()
        {
            Console.WriteLine("with out virtual keyword");
        }
    }

    public class DerivedClass : MethodHiding
    {
        public new void Print()
        {
            Console.WriteLine("using new keyword");
        }

    }
    public class EnterMain
    {
        public static void Main()
        {
            MethodHiding hide = new DerivedClass();
            hide.Print();
        }
    }
    
    }
