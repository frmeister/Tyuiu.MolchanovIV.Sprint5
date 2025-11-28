using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint5.Task1.V8.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task1.V8
{
    class Programm
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5, stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.Title = "Спринт #5 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция (произвести табулирование) f(x) на заданном диапазоне      *");
            Console.WriteLine("* [-5,5] с шагом 1. Произвести проверку деления на ноль. При делении на   *");
            Console.WriteLine("* ноль вернуть значение 0. результат сохранить в текстовый файл           *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу.                     *");
            Console.WriteLine("* Округлить до двух знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}