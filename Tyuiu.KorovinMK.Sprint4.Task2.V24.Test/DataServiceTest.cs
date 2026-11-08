using Tyuiu.KorovinMK.Sprint4.Task2.V24.Lib;
namespace Tyuiu.KorovinMK.Sprint4.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 5, 7, 8, 6, 4, 6, 6, 7, 8, 9, 5 };
            int res = ds.Calculate(numsArray);
            int wait = 33;
            Assert.AreEqual(wait, res);
        }
    }
}
