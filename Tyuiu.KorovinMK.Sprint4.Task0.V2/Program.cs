using Tyuiu.KorovinMK.Sprint4.Task0.V2.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.Tyuiu.KorovinMK.Sprint4.Task0.V2;

class Program
{

    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #0                                                                *");
        Console.WriteLine("* Вариант #2                                                                *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
        Console.WriteLine("Исходный массив :");
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.WriteLine(numsArray[i]);
        }




        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Сумма всех нечетных элементов массива:");
        int sum = 0;
        for (int i = 0; i < numsArray.Length; i++)
        {
            if (numsArray[i] % 2 != 0)
            {
                sum = sum + numsArray[i];
            }
        }
        Console.WriteLine(sum);

        Console.ReadKey();

    }
}