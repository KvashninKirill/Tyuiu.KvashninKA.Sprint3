using Tyuiu.KvashninKA.Sprint3.Task5.V21.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task5.V21;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #5                                                                                           *");
        Console.WriteLine("* Вариант #21                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        int x = 2;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 10;

        Console.WriteLine($"Переменная X: {x}");
        Console.WriteLine($"Старт внешнего цикла: {startValue1}");
        Console.WriteLine($"Конец внешнего цикла: {stopValue1}");
        Console.WriteLine($"Старт внутреннего цикла: {startValue2}");
        Console.WriteLine($"Конец внутреннего цикла: {stopValue2}");


        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        Console.WriteLine($"Результат выражения: {res}");


        Console.ReadLine();
    }
}