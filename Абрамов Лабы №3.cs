using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_23v
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Введите размер массива: ");
                var userWariable = Convert.ToInt32(Console.ReadLine()); 
                #region исключение ошибки
                if (userWariable <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nМассив не может состоять из {0} элементов.\n", userWariable);
                    Console.ReadLine();
                    return;
                }
                #endregion
                int[] FirstMassive = new int[userWariable];
                Random randomWariable = new Random(); 
                #region генератор массива
                for (var firstCycle = 0; firstCycle < userWariable; firstCycle++)
                {
                    FirstMassive[firstCycle] = randomWariable.Next(-10, 10);
                }
                #endregion
                #region сортировщик массива
                Console.WriteLine("Сгенерированный массив: " + string.Join(" ", FirstMassive)); 
                Console.WriteLine("Максимальный элемент массива: {0}", FirstMassive.Max()); 
                Console.WriteLine("Минимальный элемент массива: {0}", FirstMassive.Min()); 
                FirstMassive = FirstMassive.OrderBy(x => x).ToArray(); 
                Console.Write("Отсортированный массив(По возрастанию): " + string.Join(" ", FirstMassive) + "\n");
                #endregion
                Console.ReadLine();
            }
        }
    }
}
