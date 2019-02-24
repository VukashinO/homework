using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            var countForSpaces = 10;
            var countForThree = 1;
            var countForEnd = 3;
           for(var i = 0; i < 10; i++)
            {
               for(var j = 0; j < countForSpaces; j++)
                {
                    Console.Write(" ");
                }
               for(var k = 0; k < countForThree; k++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("* ");
                }

                
               
                Console.WriteLine();
                countForSpaces--;
                countForThree++;
            }

           for(var i = 0; i < countForEnd; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("          *");
            }
            Console.ResetColor();
        }
    }
}
