using Tyuiu.KorovinMK.Sprint4.Task7.V18.Lib;
namespace Tyuiu.Tyuiu.KorovinMK.Sprint4.Task7.V18;

class Program
{

    public static void Main(string[] args)
    {
        int n = 5;
        int m = 3;
        int[,] mtrx = new int[n, m];
        string str = "145258749635789";
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #7                                                                *");
        Console.WriteLine("* Вариант #18                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        int index = 0;

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < n; i++)
        {
            for ( int j = 0; j < m; j++)
            {
                Console.Write($"{str[index], 4}");
                index++;
            }
            Console.WriteLine();
        }



        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        int res = ds.Calculate(n, m, str);

        Console.WriteLine("Произведение четных чисел равно:" + res);


        Console.ReadKey();

    }
}
