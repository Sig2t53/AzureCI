using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCI.App
{
    public static class Adder
    {
        public static int Add(int a,int b)
        {
            return a + b*2;
        }

        public static void DuplicateMethod()
        {
            Console.WriteLine("重複しています");
            return;
        }

        public static void complexMethod()
        {
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    if (b == 0) { break; }
                    for (int c = 0; c < 10; c++)
                    {
                        Console.WriteLine(c);
                    }
                }
                if (a % 2 == 0)
                {
                    for (int d = a; d < 10; d++)
                    {
                        for (int e = 0; e < 10; e++)
                        {
                            if (d % 1 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                            if (d % 2 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                            if (d % 3 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                            if (d % 4 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                            if (d % 5 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                            if (d % 6 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                            if (d % 7 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                            if (d % 8 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                            if (d % 9 == 0) { Console.WriteLine(d); } else { Console.WriteLine(e); }
                        }
                        if (d % 1 == 0) { Console.WriteLine(d); }
                        if (d % 2 == 0) { Console.WriteLine(d); }
                        if (d % 3 == 0) { Console.WriteLine(d); }
                        if (d % 4 == 0) { Console.WriteLine(d); }
                        if (d % 5 == 0) { Console.WriteLine(d); }
                        if (d % 6 == 0) { Console.WriteLine(d); }
                        if (d % 7 == 0) { Console.WriteLine(d); }
                        if (d % 8 == 0) { Console.WriteLine(d); }
                        if (d % 9 == 0) { Console.WriteLine(d); }
                    }
                }
            }
        }
    }
}
