using Tyuiu.AshirovaDA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.AshirovaDA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 5, 6, 7, 8, 9, 5, 4, 6, 8, 9, 7, 5, 4 };

            int res = ds.Calculate(array);
            int wait = 47;

            Assert.AreEqual(wait, res);
        }
    }
}