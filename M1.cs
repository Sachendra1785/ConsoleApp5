using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal abstract partial class MCA
    {
        public abstract void abstractFun1();
        public void F1()
        {
            Console.WriteLine("Function F1");
        }
        public void F2()
        {
            Console.WriteLine("Function F2");
        }

        public static void display() {
            Console.WriteLine("Static Method of MCA class");
        }
    }
}
