using Tyuiu.KvashninKA.Sprint3.Task1.V17.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task1.V17.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 4;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 482982.891; 

            Assert.AreEqual(wait, res);
        }
    }
}
