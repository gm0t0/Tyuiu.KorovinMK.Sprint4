using Tyuiu.KorovinMK.Sprint4.Task2.V24.Lib;
namespace Tyuiu.Tyuiu.KorovinMK.Sprint4.Task2.V24;

class Program
{

    public static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #2                                                                *");
        Console.WriteLine("* Вариант #24                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        int len;
        Console.Write("Введите количество элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i < len; i++)
        {
            numsArray[i] = rnd.Next(4, 9);
        }
        Console.WriteLine();
        Console.Write("Массив:");
        for (int i = 0; i < len; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Сумма всех нечетных элементов массива:");
        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);

        Console.ReadKey();

    }
}