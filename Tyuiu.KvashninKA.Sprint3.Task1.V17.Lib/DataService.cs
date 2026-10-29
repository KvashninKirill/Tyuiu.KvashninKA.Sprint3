using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KvashninKA.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k = startValue;
            while (k <= stopValue)
            {
                multiplySeries = multiplySeries * (Math.Pow((2 / Math.Cos(value)), k));
                k++;
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
