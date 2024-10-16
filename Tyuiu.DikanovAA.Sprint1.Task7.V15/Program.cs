using Tyuiu.DikanovAA.Sprint1.Task7.V15.Lib;
namespace Tyuiu.DikanovAA.Sprint1.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Диканов А. А. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Диканов Артём Алексеевич | РППб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("* Формула:                                                                *");
            Console.WriteLine("*                      3     2                                            *");
            Console.WriteLine("*       2    3    cos x  + 7x                                             *");
            Console.WriteLine("* z = |x  - x | - -----------                                             *");
            Console.WriteLine("*                    3                                                    *");
            Console.WriteLine("*                   x  - 15x                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.WriteLine("Введите х: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
           
            Console.WriteLine("z = " + Math.Round(ds.Calculate(x), 3));
            Console.ReadKey();




        }
    }
}
