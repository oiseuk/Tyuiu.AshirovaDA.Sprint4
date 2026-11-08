using System;
using Tyuiu.AshirovaDA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.AshirovaDA.Sprint4.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Аширова Д.А. | ...";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Аширова Д.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму нечетных элементов    *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[14];
            Random rnd = new Random();

            Console.Write("* Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(4, 10);
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine($"* Сумма нечетных элементов = {res}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}