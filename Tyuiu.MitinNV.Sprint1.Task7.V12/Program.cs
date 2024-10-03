using Tyuiu.MitinNV.Sprint1.Task7.V12.Lib;
namespace Tyuiu.MitinNV.Sprint1.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая вычисляет математическое выражение по исходны*");
            Console.WriteLine("*ым значениям данных, вводимых пользователем. Ответ округлите до 3 знаков *");
            Console.WriteLine("* после запятой.                                                          *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Введите x:");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            var y = Convert.ToDouble(Console.ReadLine());

            var result = ds.Calculate(x, y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}