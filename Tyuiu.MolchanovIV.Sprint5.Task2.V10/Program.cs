using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint5.Task2.V10.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task2.V10
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] arr = { { 4, 3, -3 }, { -5, -6, -3 }, { -7, -9, -9 } };

            string path = ds.SaveToFileTextData(arr);

            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            Console.Title = "Спринт #5 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива        *");
            Console.WriteLine("* на 1, отрицательные на 0. Результат сохранить в файл                    *");
            Console.WriteLine("* OutPutFileTask2.csv  и вывести на консоль.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1) Console.Write(arr[i, j] + "; ");
                    else Console.WriteLine(arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}