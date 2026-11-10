using Tyuiu.KorovinMK.Sprint4.Task4.V27.Lib;
namespace Tyuiu.KorovinMK.Sprint4.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { {4, 3, 9, 2, 2, },
                                          {8, 4, 1, 4, 3, },
                                          {3, 9, 2, 2, 5, },
                                          {4, 6, 8, 5, 6, },
                                          {1, 5, 2, 2, 5, }  };
            int res = ds.Calculate(mas2);
            int wait = 49;
            Assert.AreEqual(wait, res);
        }
    }
}
