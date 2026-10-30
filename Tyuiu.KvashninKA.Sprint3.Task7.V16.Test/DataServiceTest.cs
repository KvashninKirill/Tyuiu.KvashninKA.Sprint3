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

            int len = (stopValue - startValue) + 1;

            double[] wait;
            wait = new double[len];

            double[] res = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(len, res.Length);
        }
    }
}
