using Tyuiu.AshirovaDA.Sprint4.Task7.V7.Lib;

namespace Tyuiu.AshirovaDA.Sprint4.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Аширова Д.А. | ...";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Преобразование строки в матрицу                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Аширова Д.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"31415926\". Преобразуйте ее в        *");
            Console.WriteLine("* матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 4;
            int m = 2;
            string str = "31415926";

            Console.WriteLine($"* Исходная строка: {str}");
            Console.WriteLine($"* Размер матрицы: {n} на {m}");

            int[,] matrix = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(str[index].ToString());
                    index++;
                }
            }

            Console.WriteLine("* Сгенерированная матрица:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);
            Console.WriteLine($"* Количество нечетных чисел = {res}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}