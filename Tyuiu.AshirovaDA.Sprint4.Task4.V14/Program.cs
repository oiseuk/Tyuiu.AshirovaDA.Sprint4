using System;
using Tyuiu.AshirovaDA.Sprint4.Task4.V14.Lib;

namespace Tyuiu.AshirovaDA.Sprint4.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Аширова Д.А. | ...";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Аширова Д.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8. Заменить нечетные        *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = {
                { 1, 3, 7, 7, 6 },
                { 4, 2, 6, 3, 3 },
                { 4, 5, 1, 4, 6 },
                { 7, 5, 2, 7, 7 },
                { 2, 4, 4, 4, 7 }
            };

            Console.WriteLine("* Исходный массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("* ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] res = ds.Calculate(matrix);

            Console.WriteLine("* Измененный массив:");
            for (int i = 0; i < res.GetLength(0); i++)
            {
                Console.Write("* ");
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}