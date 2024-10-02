﻿using Tyuiu.MitinNV.Sprint1.Task3.V18.Lib;
namespace Tyuiu.MitinNV.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Операторы составного присваивания                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*НапНаписать программу, которая запрашивает у пользователя исходные данные*");
            Console.WriteLine("*е, выполняет указанные расчёты и печатает результат на экране.           *");

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
            double a, b, c;
            Console.WriteLine("Введите a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c:");
            c = Convert.ToDouble(Console.ReadLine());


            var result = ds.HowManySquares(a, b, c);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}