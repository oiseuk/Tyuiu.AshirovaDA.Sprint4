using Tyuiu.AshirovaDA.Sprint4.Task5.V12.Lib;

namespace Tyuiu.AshirovaDA.Sprint4.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { -5, 2, 3, -1, 0 },
                { 4, -6, 1, 2, 3 },
                { 0, 1, -2, -3, 4 },
                { 2, 3, 4, 1, 0 },
                { -1, -2, 3, 4, 2 }
            };

            int res = ds.Calculate(matrix);
            int wait = 7;

            Assert.AreEqual(wait, res);
        }
    }
}