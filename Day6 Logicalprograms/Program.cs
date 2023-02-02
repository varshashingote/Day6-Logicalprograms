using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string value;

            
            do
            {
                Console.WriteLine("Enter Your choice(\n1.Fibonacci\n2.perfectNo\n3.PrimeNo\n4.ReverseNum\n5.StopWatch\n6.CupoonNo" +
                                   "\n7.VendingMachinen\n8 MonthlyPayment\n9TemperatureConversion\n10SwapNib");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Fibonacci fb = new Fibonacci();
                        fb.FindFibo();
                        break;
                    case 2:
                        PerfectNo perfectNo = new PerfectNo();
                        perfectNo.FindperfectNo();
                        break;
                    case 3:
                        PrimeNo prime = new PrimeNo();
                        prime.FindPrimeNo();
                        break;
                    case 4:
                        ReverseNum reverse = new ReverseNum();
                        reverse.FindReveseNum();
                        break;
                    case 5:
                        StopManuallyTime stopManuallyTime = new StopManuallyTime();
                        stopManuallyTime.Start();
                        break;
                    case 6:
                        CupoonNo cupoon = new CupoonNo();
                        cupoon.Coupon_Numbers();
                        break;
                    case 7:
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.vm();
                        break;
                    case 8:
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.monthlyPaymentfind();
                       break;
                    case 9:
                        TempertatureConversion tempertatureConversion = new TempertatureConversion();
                        tempertatureConversion.TempertatureConversionFind();
                        tempertatureConversion.temperaturConversionToCelsius();
                        break;
                    case 10:
                        SwapNib swapNib = new SwapNib();
                        swapNib.SwapNibbles(100);
                        break;
                    default:
                        Console.WriteLine("Not Avaliable");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Do you want to continue(Y/N):");
                value = Console.ReadLine();
            } while (value == "Y" || value == "N");
        }
    }
}

















