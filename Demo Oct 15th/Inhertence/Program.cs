using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertence
{
    class Program
    {
        static void Main(string[] args)
        {
            //test methos inheritance
            ChildClass cc = new ChildClass();
            GrandchildClass1 gcc = new GrandchildClass1();

            Console.WriteLine("Calling methods from gcc");
            gcc.BaseMethod();
            gcc.ChildMethod();
            //gcc.GrandChildMethod();
            Console.WriteLine();

            //test base class fields
            BaseClass bc = new BaseClass(12, 45);
            bc.PrintState();
            Console.WriteLine();

            //test child print state
            ChildClass cc2 = new ChildClass(987, 654, 345);
            cc2.PrintState();
        }
    }
}
