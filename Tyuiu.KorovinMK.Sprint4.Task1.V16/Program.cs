using Tyuiu.KorovinMK.Sprint4.Task1.V16.Lib;
namespace Tyuiu.Tyuiu.KorovinMK.Sprint4.Task1.V16;

class Program
{

    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #1                                                                *");
        Console.WriteLine("* Вариант #16                                                               *");
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

        for ( int i = 0; i < len; i++)
        {
            Console.Write("Введите значение " + i + " элемента массива:");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Массив:");
        for (int i = 0; i < len; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Произведение всех нечетных элементов массива:");
        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);

        Console.ReadKey();

    }
}