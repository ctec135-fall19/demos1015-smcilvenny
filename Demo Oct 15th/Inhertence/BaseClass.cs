using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertence
{
    class BaseClass
    {
        private int basePrivateInt;
        protected int baseProtectedInt;

        //constructers

        public BaseClass() { }
        public BaseClass(int privateInt, int protectedInt)
        {
            this.basePrivateInt = privateInt;
            this.baseProtectedInt = protectedInt;
        }



        //methods
        public void BaseMethod()
        {

            Console.WriteLine("BaseClass.BaseMethod");

        }

        public virtual void PrintState()
        {
            Console.WriteLine("BaseClass object");
            Console.WriteLine("\tBasePrivateInt: {0}", basePrivateInt);
            Console.WriteLine("\tBaseProtectedInt: {0}", baseProtectedInt);
        }
    }
}
