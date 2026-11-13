using Tyuiu.KvashninKA.Sprint3.Task7.V16.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task7.V16.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] wait = new double[]
            {
                -36.41, -22.07, 5.68, 16.72, 8.35, -0.5, 9.63, 16.29, 5.01, -22.4, -36.3
            };

            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
