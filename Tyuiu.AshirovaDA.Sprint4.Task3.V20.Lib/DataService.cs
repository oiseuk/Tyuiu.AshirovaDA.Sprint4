using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AshirovaDA.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int min = array[0, 0];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[i, 0] < min)
                {
                    min = array[i, 0];
                }
            }

            return min;
        }
    }
}