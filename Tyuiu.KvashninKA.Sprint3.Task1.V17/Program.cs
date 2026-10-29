
using Tyuiu.KvashninKA.Sprint3.Task1.V17.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task1.V17;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #1                                                                                           *");
        Console.WriteLine("* Вариант #17                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение ряда по формуле, при х=1     *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        int value = 1;
        int startValue = 1;
        int stopValue = 4;

        Console.WriteLine($"Переменная a = {value}");
        Console.WriteLine($"Стартовый шаг k = {startValue}");
        Console.WriteLine($"Конечный шаг k = {stopValue}");

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        double res = ds.GetMultiplySeries(value, startValue, stopValue);

        Console.WriteLine($"Произведение ряда равно = {res}");


        Console.ReadLine();
    }
}