using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5_Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n ; i++)
            {
                Console.Write(new string('-', n * 3));
                Console.Write('*');
                for (int c = 0; c <= i - 1 ; c++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                Console.WriteLine(new string('-', (n - i)+(n - 2)));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', n * 3));
                Console.Write('*');
                Console.Write(new string('-', n - 1));
                Console.Write('*');
                Console.WriteLine(new string('-', n - 1));
            }
            if (n >= 5)
            {
                for (int i = 0; i <= n - 3 ; i++)
                {
                    Console.Write(new string('-', n * 3 -  i ));
                    Console.Write('*');
                    Console.Write(new string('-', n - 3 + (i + 2)));
                    for (int c = 0; c <= i - 1; c++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                    Console.WriteLine(new string('-', (n - i) - 1));
                    if (i == n - 3)
                    {
                Console.Write(new string('-', (n * 3 - i) - 1));
                Console.Write(new string('*', n * 2 + i));
                Console.WriteLine(new string('-', 1));
                    }                    
                }
            }
            else
            {
                Console.Write(new string('-', n * 3 ));
                Console.Write(new string('*', n + 1));
                Console.WriteLine(new string('-', n - 1));
            }
        }
    }
}
