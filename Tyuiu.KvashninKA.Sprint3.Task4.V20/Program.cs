using Tyuiu.KvashninKA.Sprint3.Task4.V20.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task4.V20;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #4                                                                                           *");
        Console.WriteLine("* Вариант #20                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=x/(cos(x) - x)+2,5     *");
        Console.WriteLine("* При х = 0 пропустить значение. Полученные значения перемножать                                       *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine($"Старт шага: {startValue}");
        Console.WriteLine($"Конец шага: {stopValue}");


        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        double res = ds.Calculate(startValue, stopValue);

        Console.WriteLine($"Результат выражения: {res}");


        Console.ReadLine();
    }
}