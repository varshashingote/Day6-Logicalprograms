using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
  public class CupoonNo
    {
        public void Coupon_Numbers()


        {
            // random number to gertrated for coupon

            Console.WriteLine("how many coupon number you required ?");
            int Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("genreted coupon number");



            for (int i = 0; i < Number; i++)
            {
                Random number = new Random();
                int cuopon = number.Next(10000, 100000);

                Console.WriteLine(cuopon);
                Console.ReadLine();
            }

        }


    }
}
