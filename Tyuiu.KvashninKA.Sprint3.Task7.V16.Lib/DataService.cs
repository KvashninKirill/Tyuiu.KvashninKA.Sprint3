using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KvashninKA.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Sin(x) / (x + 1.2)) - (Math.Cos(x) * 4 * x) + 2;
                }

                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}
