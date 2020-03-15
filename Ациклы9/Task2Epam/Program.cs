using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
  
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            double x = 0;

            try
            {
                Console.WriteLine("Введите k и x");
                string строкаВвода = Console.ReadLine();
                string[] аргумент = строкаВвода.Split(' ');
                k = Convert.ToInt16(аргумент[0]);
                x = Convert.ToDouble(аргумент[1]);
            }
            catch
            {
                Console.WriteLine("неверные данные");
                Main(args);
            }
            double слагаемое = 0, сумма = слагаемое;
            for (int n = 1; n <= k; n++)
            {
                
                слагаемое = Math.Pow(-1, n + 1) * Math.Pow(x, 2 * n + 1) / (4 * Math.Pow(n, 2) - 1);
                сумма += слагаемое;
            }
            Console.Write(сумма);
            Console.ReadLine();
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
