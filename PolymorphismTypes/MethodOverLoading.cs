using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTypes
{
    public class MethodOverLoading
    {
        public int Add(int a, int b)
        {
            return a + b;


        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;

        }
    }

      public class Enter
    {
        public static void Main()
        {
            MethodOverLoading cal = new MethodOverLoading();
            cal.Add(2, 3);
            cal.Add(2, 3, 4);
            cal.Add(2.3, 2.4);
        }
    }

}
