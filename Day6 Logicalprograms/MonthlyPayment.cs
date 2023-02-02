using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
    public class MonthlyPayment
    {
        public static double P, Y, R, Monthly_Payment, n, r;
        public void monthlyPaymentfind()
        {
            Console.WriteLine("Enter Percent Interest & Principal & Year");
            double R = Convert.ToDouble(Console.ReadLine());
            double P= Convert.ToDouble(Console.ReadLine()); 
            int Y= Convert.ToInt32(Console.ReadLine());    

            n = 12 * Y;
            r = R / (12 * 100);
            Monthly_Payment=(P * r) / (1-( Math.Pow((1+r), -n)));
            Console.WriteLine("Monthly Payment is:"+ Monthly_Payment);
        }
    }
}
