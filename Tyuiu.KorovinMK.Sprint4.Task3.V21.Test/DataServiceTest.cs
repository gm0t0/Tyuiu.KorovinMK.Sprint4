using Tyuiu.KorovinMK.Sprint4.Task3.V21.Lib;
namespace Tyuiu.KorovinMK.Sprint4.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { {8, 3, 3, 3, 5, },
                                          {6, 7, 3, 3, 7, },
                                          {4, 5, 4, 6, 6, },
                                          {5, 5, 8, 8, 7, },
                                          {4, 6, 6, 7, 7, }  };
            int res = ds.Calculate(mas2);
            int wait = 10290;
            Assert.AreEqual(wait, res);
        }
    }
}
