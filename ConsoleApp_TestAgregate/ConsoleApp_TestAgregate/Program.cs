using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TestAgregate
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            string[] numstrs = nums.Select(i => i.ToString()).ToArray();
            //string numstr= numstrs.Aggregate((x, y) => x + '|' + y);
            string numstr = numstrs.Where(i => i.Equals("5") ).Aggregate((x, y) => x + '|' + y);
            for (int i = 0; i < numstr.Length; i++) {
                Console.WriteLine(" {0}",numstr[i]);
            }
            Console.WriteLine(numstr);

        }
    }
}
