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
            int startNumber = 7;
            int endNumber = 98;
            int sequenceStep = 7;

            for (int i = startNumber; i <= endNumber; i += sequenceStep)
                Console.Write(i + " ");
        }
    }
}