using Tyuiu.KorovinMK.Sprint4.Task1.V16.Lib;
namespace Tyuiu.KorovinMK.Sprint4.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 11907;
            Assert.AreEqual(wait, res);

        }
    }
}
