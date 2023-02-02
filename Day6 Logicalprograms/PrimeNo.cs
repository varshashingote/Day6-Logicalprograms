using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
    internal class PrimeNo
    {
        public void FindPrimeNo()
        {
            int n, i, ctr = 0;
            Console.WriteLine("Enter the Number to check Prime: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    ctr++;
                    break;

                }
            }
                if (ctr == 0 && n!=1)
                Console.Write("Number is Prime.");
                else
                Console.WriteLine("Number is not prime");
                Console.ReadLine();
            
          
        }
    }
}  
   
