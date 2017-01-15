using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitSimple
{
    [TestFixture, Description("Check out closure")]
    class ClosureExample
    {
        [Test]
        public void TestClosure()
        {
            var inc = GetAFunc();
            Console.WriteLine(inc(5));
            Console.WriteLine(inc(6));
        }

        public Func<int, int> GetAFunc()
        {
            var myVar = 1;
            Func<int, int> inc = delegate (int var1) //a delegate is a type safe function pointer 
            {
                myVar = myVar + 1;
                return var1 + myVar;
            };
            return inc;
        }
    }
}
