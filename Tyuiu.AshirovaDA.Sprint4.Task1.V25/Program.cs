using System;
using Tyuiu.AshirovaDA.Sprint4.Task1.V25.Lib;

namespace Tyuiu.AshirovaDA.Sprint4.Task1.V25
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Аширова Д.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму          *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[14];

            Console.WriteLine("* Введите 14 чисел (от 1 до 7):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"* Элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine($"* Сумма четных элементов = {res}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}