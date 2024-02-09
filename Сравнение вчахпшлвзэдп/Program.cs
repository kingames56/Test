using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сравнение_вчахпшлвзэдп
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2 число");
            int b = Convert.ToInt32(Console.ReadLine());
       
            if (a > b) 
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(a);
            
            if (b > a)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(b);

            if (a == b) 
                Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine(b);

        }
    }
}
