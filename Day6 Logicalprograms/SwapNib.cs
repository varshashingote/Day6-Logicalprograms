using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
    internal class SwapNib
    {
        public int n;
        public int SwapNibbles(int n)
        {
            int right = (n & 0b00001111);
            right = (right << 4);
            Console.WriteLine(""+right);
            int left = (n & 0b11110000);
            left = (left >> 4);
            Console.WriteLine(""+left);
            return (right | left);
        }
    }
}
