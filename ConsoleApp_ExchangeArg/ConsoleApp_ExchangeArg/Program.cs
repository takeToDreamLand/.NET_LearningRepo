using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ExchangeArg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            //Exchange(ref a, ref b);
            A A = new A();
            A.Exchange(ref a, ref b); 
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Exchange(ref int left, ref int right)
        {
            int temp;
            temp = left;
            left = right;
            right = temp;
        } 
    }
    public class A
    {
        public void Exchange(ref int left, ref int right)
        {
            int temp;
            temp = left;
            left = right;
            right = temp;
        }
    }
}
