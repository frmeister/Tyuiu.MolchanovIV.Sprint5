using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint5.Task0.V15.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task0.V15
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            int input = 3;

            string path = ds.SaveToFileTextData(input);

            Console.Title = "Спринт #5 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль.                *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + input);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}