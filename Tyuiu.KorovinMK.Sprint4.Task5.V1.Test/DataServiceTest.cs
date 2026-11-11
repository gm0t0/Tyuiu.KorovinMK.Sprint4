using Tyuiu.KorovinMK.Sprint4.Task5.V1.Lib;
namespace Tyuiu.KorovinMK.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas1 = new int[5, 5] { {-9, -5, -6, 6, 7  },
                                          {-8, -4, -1, 4, 3,  },
                                          {-3, -5, -2, 2, 5, },
                                          {-4, -6, -8, 5, 6,  },
                                          {-1, -5, -2, -2, -5  } };
            int[,] res = ds.Calculate(mas1);
            int[,] wait = new int [ 5, 5] { {-9, -5, -6, 1, 1  },
                                          {-8, -4, -1, 1, 1,  },
                                          {-3, -5, -2, 1, 1, },
                                          {-4, -6, -8, 1, 1,  },
                                          {-1, -5, -2, -2, -5  } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
