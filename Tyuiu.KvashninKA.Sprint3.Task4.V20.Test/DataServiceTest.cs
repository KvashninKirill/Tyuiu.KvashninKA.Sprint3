
using Tyuiu.KvashninKA.Sprint3.Task4.V20.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task4.V20.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 10.483; 

            Assert.AreEqual(wait, res);
        }
    }
}
