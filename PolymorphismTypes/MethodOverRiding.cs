using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTypes
{
    public class ParentClass
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent method");
        }
        
    }
    public  class ChildClass : ParentClass
    {
        public override void Show()
        {
            Console.WriteLine("child Method");
           
        }

    }
    public class EntryPoint
    {
        public static void Main()
        {
           // ParentClass p = new ParentClass();
            ParentClass c = new ChildClass();
            //p.Show();
            c.Show();

        }
    }
}
