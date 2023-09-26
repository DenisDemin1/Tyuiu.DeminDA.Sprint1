using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DeminDA.Sprint1.Task5.V5.Lib;


namespace Tyuiu.DeminDA.Sprint1.Task5.V5
{
    class Program
    {
        static void Main (string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнил: Дёмин Д.А. | ИИПБ-23-2";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #95                                                            *");
            Console.WriteLine("* Выполнил: Дёмин Денис Александрович | ИИПБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части              *");
            Console.WriteLine("*положительного вещественного числа x (так, если x=32.597, то d=5).       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x));
            
            Console.WriteLine("Ответ = " + res);
            Console.ReadLine();
        }
    }
}
