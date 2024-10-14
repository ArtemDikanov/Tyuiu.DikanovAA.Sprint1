using Tyuiu.DikanovAA.Sprint1.Task4.V29.Lib;
namespace Tyuiu.DikanovAA.Sprint1.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Диканов А. А. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Диканов Артём Алексеевич | РППб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой. Формула:                     *");
            Console.WriteLine("* ((2 + |x - 2y|)^0.5)                                                    *");
            Console.WriteLine("* --------------------                                                    *");
            Console.WriteLine("*       (3xy^2)                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение х: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение у: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("((2 + |x - 2y|)^0.5) / (3xy^2) - " + Math.Round(ds.Calculate(x, y), 3));

            Console.ReadKey();



        }
    }
}
