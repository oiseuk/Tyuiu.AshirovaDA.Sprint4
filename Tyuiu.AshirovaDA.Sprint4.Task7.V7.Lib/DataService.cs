using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AshirovaDA.Sprint4.Task7.V7.Lib
{
    public class DataService : ISprint4Task7V7
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}