using System;
using System.Collections.Generic;
using System.Text;

namespace hello
{
    class baitap
    {
         static void Main(String[] args)
        {
            string number = "qwead";

            int count = 0;

        beginLoop:

            Console.WriteLine(number);
            count ++;
            if(count < 10)
            goto beginLoop;

            Console.WriteLine("weq");
            Console.ReadKey();

        }
    }
}
