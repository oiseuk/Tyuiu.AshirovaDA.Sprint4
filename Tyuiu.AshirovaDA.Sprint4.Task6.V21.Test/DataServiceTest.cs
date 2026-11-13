using Tyuiu.AshirovaDA.Sprint4.Task6.V21.Lib;

namespace Tyuiu.AshirovaDA.Sprint4.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };

            int res = ds.Calculate(array);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}