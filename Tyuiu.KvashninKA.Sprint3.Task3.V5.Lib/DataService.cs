using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KvashninKA.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string res = "";
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    res += replacement;
                }
                else
                {
                    res += c;
                }
            }
            return res;
        }
    }
}
