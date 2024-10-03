using Tyuiu.MitinNV.Sprint1.Task6.V4.Lib;
namespace Tyuiu.MitinNV.Sprint1.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Работа со строками класс String                                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу: пользователь вводит текст. Напечатать все слова, соде*");
            Console.WriteLine("*ержащие удвоенное н ('нн').                                              *");

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
            Console.WriteLine("Введите строку:");
            var a = Console.ReadLine();
            var result = ds.CheckDoubleN(a); 
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}