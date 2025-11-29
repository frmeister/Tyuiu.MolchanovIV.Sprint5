using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Tyuiu.MolchanovIV.Sprint5.Task7.V30.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task7.V30
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();

            string inputPath = $@"C:\DataSprint5\InPutDataFileTask7V30.txt";

            Console.Title = "Спринт #5 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V30.txt (файл взять         *");
            Console.WriteLine("* из архива согласно вашему варианту. Создать папку в ручную              *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор        *");
            Console.WriteLine("* символьных данных.Заменить все однозначные числа на число \"9\".        *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V30.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находятся в файле: " + inputPath);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл: " + ds.LoadDataAndSave(inputPath));
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}