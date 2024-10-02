using Tyuiu.MitinNV.Sprint1.Task5.V2.Lib;
namespace Tyuiu.MitinNV.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Преобразование типов и класс Convert                                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая решает следующую задачу: Дано значение темпер*");
            Console.WriteLine("*ратуры в градусах Фаренгейта. Определить значение этой же температуры в г*");
            Console.WriteLine("*градусах Цельсия. Ответ привести к целому с помощью класса Convert.      *");

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
            Console.WriteLine("Введите a:");
            var a = Convert.ToDouble(Console.ReadLine());
            var result = ds.FahrenheitToСelsius(a);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}