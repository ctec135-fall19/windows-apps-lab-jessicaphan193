using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    partial class MyClass
    {
        public MyClass(int x)
        {
            this.myfield = x;
        }
        public void printState()
        {
            Console.WriteLine("state: {0}", myfield);
        }
    }
}
