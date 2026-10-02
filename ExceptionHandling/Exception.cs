using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Exception
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter a:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b:");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("print c:" + c);
                List<int> s = new List<int>();
                s.Add(1);
                    s.Add(2);
                Console.WriteLine("list s:" + s.Count);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }

        }
           

        
        
        
    }
}
