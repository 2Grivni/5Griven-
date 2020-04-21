using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_23v
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Расчет по формуле квадратного уравнения.");
                Console.Write("Введите число A: ");
                var A = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Введите число B: ");
                var B = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Введите число C: ");
                var C = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Ответ: " + (B * B - 4 * A * C)); 

                Console.ReadLine();
            }
        }
    }
}
