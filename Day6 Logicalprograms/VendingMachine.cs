using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
    internal class VendingMachine
    {
        public void vm()
        {


            
            Console.WriteLine("Enter the amount you want to withdraw");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount >= 1000) {
                int notesOfThousand = amount / 1000;
                amount = amount - (notesOfThousand * 1000);
                Console.WriteLine("1000 RS =" + notesOfThousand + " notes");
            }
            if (amount >= 500) {
                int notesOfFiveHundred = amount / 500;
                amount = amount - (notesOfFiveHundred * 500);
                Console.WriteLine("500 RS =" + notesOfFiveHundred + " notes");
            }
            if (amount >= 200)
            {
                int notesoftwoHunderd = amount / 200;
                amount = amount - (notesoftwoHunderd * 200);
                Console.WriteLine("200 RS ="+ notesoftwoHunderd + "notes");
            }
            if (amount >= 100)
            {
                int notesOfHundred = amount / 100;
                amount = amount - (notesOfHundred * 100);
                Console.WriteLine("100 RS =" + notesOfHundred + " notes");
            }
            if (amount >= 50)
            {
                int notesOfFifty = amount / 50;
                amount = amount - (notesOfFifty * 50);
                Console.WriteLine("50 RS =" + notesOfFifty + " notes");
            }
            if (amount >= 20)
            {
                int notesOfTwenty = amount / 20;
                amount = amount - (notesOfTwenty * 20);
                Console.WriteLine("20 RS =" + notesOfTwenty + " notes");
            }
            if (amount >= 1)
            {
                int notesOfTen = amount / 10;
                amount = amount - (notesOfTen * 10);
                Console.WriteLine("10 RS =" + notesOfTen + " notes");
            }
            if (amount >= 5)
            {
                int coinOfFive = amount / 5;
                amount = amount - (coinOfFive * 5);
                Console.WriteLine("5 RS =" + coinOfFive + " coins");
            }
            if (amount >= 2)
            {
                int coinOfTwo = amount / 2;
                amount = amount - (coinOfTwo * 2);
                Console.WriteLine("2 RS =" + coinOfTwo + " coins");
            }
            if (amount >= 1)
            {
                int coinOfOne = amount / 1;
                amount = amount - (coinOfOne * 1);
                Console.WriteLine("1 RS =" + coinOfOne + " coins");
                Console.ReadLine();
            }
        }
        

    }
}



