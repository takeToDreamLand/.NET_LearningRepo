using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.F1();
        }
    }
    public class A
    {
        public int x = 1;

        public virtual void F1()
        {
            Console.WriteLine("A.F1");
        }
        public void F2()
        {
            Console.WriteLine("A.F2");
        }
    }
}
