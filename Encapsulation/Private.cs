using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Private
    {
        private int num1;
        private string name;
        public int GetNum1()
        {
            return num1;

        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }
    public class Entry
    {
        public static void Main()
        {
            Private p = new Private();
            p.SetName("abc");
        }
    }
}
