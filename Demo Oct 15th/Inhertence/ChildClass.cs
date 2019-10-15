using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertence
{
    class ChildClass : BaseClass
    {
        //fields
        protected int childProtectedInt;

        //constructers
        public ChildClass() { }
        public ChildClass(int basePrivateInt, int baseProtectedInt, int
            childProtectedInt)
            : base(basePrivateInt, baseProtectedInt)
        {
            this.childProtectedInt = childProtectedInt;
        }
    
        //methods
        public void ChildMethod()
        {
            Console.WriteLine("ChildClass.ChildMethod");
        }

        public override void PrintState()
        {
            Console.WriteLine("ChildClass object");
            //Console.WriteLine("\tBasePrivateInt: {0}", basePrivateInt);
            //Console.WriteLine("\tBaseProtectedInt: {0}", baseProtectedInt);
            base.PrintState();
            Console.WriteLine("\tchildProtectedInt: {0}", childProtectedInt);
        }
    }
}
