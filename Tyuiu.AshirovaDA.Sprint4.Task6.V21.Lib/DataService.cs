using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AshirovaDA.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < 8)
                {
                    count++;
                }
            }

            return count;
        }
    }
}