using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello you virtual world!");
            Console.Out.WriteLine("This is a bit slow, don't you think?");
            Console.Out.WriteLine("Funkar det med svenska tecken åxå? åäöÅÄÖ$/()|[]\\{}");
            Thread.Sleep(10000);
        }
    }
}
