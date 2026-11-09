using Tyuiu.KorovinMK.Sprint4.Task3.V21.Lib;
namespace Tyuiu.Tyuiu.KorovinMK.Sprint4.Task3.V21;

class Program
{

    public static void Main(string[] args)
    {
        int[,] array = new int[5, 5] {   {8, 3, 3, 3, 5, },
                                         {6, 7, 3, 3, 7, },
                                         {4, 5, 4, 6, 6, },
                                         {5, 5, 8, 8, 7, },
                                         {4, 6, 6, 7, 7, }  };
        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;


        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #3                                                                *");
        Console.WriteLine("* Вариант #21                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Массив :");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
        


        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        int res = ds.Calculate(array);

        Console.WriteLine("Произведение чисел  находящихся в 5ом столбце:" + res);
        Console.ReadKey();

    }
}