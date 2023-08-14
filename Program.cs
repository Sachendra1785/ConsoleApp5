using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MCA.display();
         
            MCA_SecC mca_C=new MCA_SecC();
            mca_C.abstractFun1();
            mca_C.F1();
            Console.Read();
        }
    }

    class MCA_SecC : MCA
    {
        public override void abstractFun1()
        {
            Console.WriteLine("Abstract Class Function implementation");
        }
    }
}
