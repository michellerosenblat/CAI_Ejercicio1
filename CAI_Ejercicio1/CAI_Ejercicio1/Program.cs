﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=593; i++)
            {
                if (i%3 == 0)
                {
                    if (i%5 == 0 )
                    {
                        Console.WriteLine(i + "- FooBar");
                    }
                    else
                    {
                        Console.WriteLine(i + "- Foo");
                    }
                    
                }
                else
                {
                    if (i%5== 0)
                    {
                        Console.WriteLine(i + "- Bar");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

               
            }
            Console.ReadKey();
        }
    }
}
