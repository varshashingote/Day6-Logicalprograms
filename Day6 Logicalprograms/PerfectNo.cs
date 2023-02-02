using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
    internal class PerfectNo
    {
        public void FindperfectNo()
        {

            //perfect number-A positive integer that is equal to the sum of its proper divisors.
            //6=1+2+3=6 perfect number,28,496 etc are perfect Number
            int sum = 0, Num;
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            Num = n;
            for (int i = 1; i < n ; i++)
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            if (sum == n)
                Console.WriteLine("Number is perfect Number");
            else
                Console.WriteLine("Number is Not perfect Number");
            Console.ReadLine();
        }
        
       

        
    }
}
