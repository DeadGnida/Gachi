using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("while: ");
            var w = 10;
            while (w++ < 99)
                if ((w % 10) * (w / 10) % 2 == 0)
                    Console.Write(w + " ");
            //Вот тут всё неправильно выводит
            Console.WriteLine();
            Console.Write("for: ");
            var f = 10;
            while (f++ < 99)
                if ((f % 10) * (f / 10) % 2 == 0)
                Console.Write(f + " ");
            // Тут вроде тоже
            Console.WriteLine();
            Console.Write("   do: ");
            var d = 10;
            while (d++ < 99)
                if ((d % 10) * (d / 10) % 2 == 0)
                Console.Write(d + " ");
            
            //Всё выводиться неверно
                Console.ReadLine();
            
        }
        555
            ytajh
            
            
            
            
            
            
            
             Вова 
            лох 
    }
}
