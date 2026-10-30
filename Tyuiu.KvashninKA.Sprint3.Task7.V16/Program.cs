using Tyuiu.KvashninKA.Sprint3.Task7.V16.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task7.V16;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #7                                                                                           *");
        Console.WriteLine("* Вариант #16                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции                                         *");
        Console.WriteLine("* (произвести таблурирование) f(x) на заданном диапазоне [-5;5]                                        *");
        Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0               *");
        Console.WriteLine("* Значения занести в массив.                                                                           *");
        Console.WriteLine("* Значения округлить до двух знаков после запятой                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Стартовое значение = " + startValue);
        Console.WriteLine("Конечное значение = " + stopValue);


        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("+----------+------------+");
        Console.WriteLine("|    X     |    F(X)    |");
        Console.WriteLine("+----------+------------+");

        double[] resultArray = ds.GetMassFunction(startValue, stopValue);

        for (int i = 0; i <= stopValue - startValue; i++)
        {
            Console.WriteLine("|,{0,6:d}    |,{1,8:f2}  |", startValue + i, resultArray[i]);
        }

        Console.WriteLine("+----------+------------+");


        Console.ReadLine();
    }
}