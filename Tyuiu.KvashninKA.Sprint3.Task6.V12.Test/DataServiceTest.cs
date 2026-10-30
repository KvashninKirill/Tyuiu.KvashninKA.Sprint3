using Tyuiu.KvashninKA.Sprint3.Task6.V12.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task6.V12.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = 9;
            int stopValue = 18;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            bool wait = true;
            Assert.AreEqual(wait, res > 0);
        }
    }
}
