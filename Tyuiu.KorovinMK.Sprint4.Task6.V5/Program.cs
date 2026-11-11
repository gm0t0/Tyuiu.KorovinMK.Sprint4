using Tyuiu.KorovinMK.Sprint4.Task6.V5.Lib;
namespace Tyuiu.Tyuiu.KorovinMK.Sprint4.Task5.V1;

class Program
{

    public static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #5                                                                *");
        Console.WriteLine("* Вариант #1                                                                *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        var planet = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
        Console.WriteLine("Исходный массив:");
        for ( int i = 0; i < planet.Length; i++ )
        {
            Console.WriteLine(planet[i]);
        }



        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");
        int res = ds.Calculate(planet);
        Console.WriteLine("Количество планет в названии которыз 5 букв:" + res);
        


        Console.ReadKey();

    }
}
