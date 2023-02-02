using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
    public class Fibonacci
    {
        public static int p1 = 0, p2 = 1, p3;
        public void FindFibo()
        {
            Console.WriteLine("Enter the Number:");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p1+"\n"+p2);
            for(int i=0;i<count; i++)
            {
                p3 = p1 + p2;
                Console.WriteLine(+p3);
                p1 = p2;
                p2 = p3;
            }
            Console.ReadLine();
        }
    }
}
