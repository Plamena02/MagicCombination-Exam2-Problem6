using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
       for (int i=1;i<=10;i++)
            {  for (int p=1;p<=10;p++)
                    for (int m=1;m<=10;m++)
                        for (int l = 1; l <= 10; l++)
                            for (int g = 1; g <= 10; g++)
                                for (int b = 1; b <= 10; b++)
                                { if (i*p*m*l*g*b==n)
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", i, p, m, l, g, b);
                                }
            }
        }
    }
}
