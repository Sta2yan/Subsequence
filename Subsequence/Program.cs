using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = 7;
            int endNum = 98;

            for (; startNum <= endNum; startNum += 7)
                Console.Write(startNum + " ");
        }
    }
}