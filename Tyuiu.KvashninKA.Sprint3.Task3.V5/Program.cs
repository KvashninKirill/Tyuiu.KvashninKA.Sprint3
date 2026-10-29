
using Tyuiu.KvashninKA.Sprint3.Task3.V5.Lib;
namespace Tyuiu.KvashninKA.Sprint3.Task3.V5;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #3                                                                                           *");
        Console.WriteLine("* Вариант #5                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Используя цикл foreach заменить буквы a  на * в строке: fifa al fall                *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        string value = "fifa al fall";
        char replaceable = 'a';
        char replacement = '*';

        Console.WriteLine($"Исходная строка: {value}");
        Console.WriteLine($"Символ для замены: {replaceable}");
        Console.WriteLine($"Символ на замену: {replacement}");


        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        string res = ds.ReplaceCharInString(value, replaceable, replacement);

        Console.WriteLine($"Результат: {res}");


        Console.ReadLine();
    }
}