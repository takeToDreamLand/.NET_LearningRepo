using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var classX = new TestClass(8);
            //X.x = 1;
            //X.error = "No";
            Console.WriteLine(classX);
        }
    }
    class TestClass
    {
        public int x;
        //public string error;
        public TestClass()
        {
            x = 5;
        }
        public TestClass(int a)
        {
            x = a;
        }
        public override string ToString()
        {
            return x.ToString();
        }

    }
}
