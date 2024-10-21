using System.IO;
using Tyuiu.NovikovDS.Sprint5.Task1.V5.Lib;

DataService ds = new();

Console.Title = "Спринт #5 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция, произвести табулирование f(x) на заданном диапазоне       *");
Console.WriteLine("* [-5, 5] с шагом 1. Произвести проверку деления на ноль (вернуть 0).     *");
Console.WriteLine("* Результат сохранить в текстовый файл и вывести в консоль.               *");
Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int start = -5, end = 5;
string path = ds.SaveToFileTextData(start, end);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Ответ записан в файл по пути:\n" + path);
Console.WriteLine("\nПолученные значения: ");

string[] massiv = File.ReadAllLines(path).ToArray();
double[] mass2 = new double[massiv.Length];

for (int i = 0; i < massiv.Length; i++)
{
    string temp = massiv[i];
    mass2[i] = Convert.ToDouble(temp);
}

int k = start;
for (int i = 0; i < mass2.Length; i++)
{
    Console.WriteLine("* X = " + k + " \tF(X) = " + mass2[i]);
    k++;
}

Console.WriteLine("***************************************************************************");
Console.ReadLine();

