using Tyuiu.KorovinMK.Sprint4.Task4.V27.Lib;
namespace Tyuiu.Tyuiu.KorovinMK.Sprint4.Task4.V27;

class Program
{

    public static void Main(string[] args)
    {
        

        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #4                                                                *");
        Console.WriteLine("* Вариант #27                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        Console.Write("Введите количество строк в массиве:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов в массиве:");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        Console.WriteLine("*****************************************************************************");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"Введите {i}, {j} элемент массива: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Массив:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }


        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Сумма всех нечетных элементов:");
        int res = ds.Calculate(matrix);

        Console.WriteLine(res);
        Console.ReadKey();

    }
}
