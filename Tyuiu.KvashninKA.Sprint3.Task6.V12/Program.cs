using Tyuiu.KvashninKA.Sprint3.Task6.V12.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task6.V12;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #6                                                                                           *");
        Console.WriteLine("* Вариант #12                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку                  *");
        Console.WriteLine("* [9, 18] сумму  всех делителей                                                                        *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        int startValue = 9;
        int stopValue = 18;

        Console.WriteLine("Стартовое значение = " + startValue);
        Console.WriteLine("Конечное значение = " + stopValue);


        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        int res = ds.GetSumTheDivisors(startValue, stopValue);

        Console.WriteLine("Сумма всех делителей на отрезке [9, 18] равна = " + res);


        Console.ReadLine();
    }
}