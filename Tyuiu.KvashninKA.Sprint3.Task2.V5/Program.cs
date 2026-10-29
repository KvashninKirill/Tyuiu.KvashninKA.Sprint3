
using Tyuiu.KvashninKA.Sprint3.Task2.V5.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task2.V5;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #2                                                                                           *");
        Console.WriteLine("* Вариант #5                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму ряда по формуле                *");
        Console.WriteLine("* при a=0,75                                                                                           *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        double value = 0.75;
        int startValue = 1;
        int stopValue = 20;

        Console.WriteLine($"Переменная a = {value}");
        Console.WriteLine($"Стартовый шаг k = {startValue}");
        Console.WriteLine($"Конечный шаг k = {stopValue}");

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        double res = ds.GetSumSeries(value, startValue, stopValue);

        Console.WriteLine($"Сумма ряда равна = {res}");


        Console.ReadLine();
    }
}