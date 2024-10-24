using Tyuiu.NovikovDS.Sprint5.Task3.V7.Lib;

DataService ds = new();

Console.Title = "Спринт #5 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение , вычислить его значение при x = 2, результат            *");
Console.WriteLine("* сохранить в бинарный файл OutPutFileTask3.bin и вывести                 *");
Console.WriteLine("* на консоль. Округлить до трёх знаков после запятой.                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 2;

Console.WriteLine("* X = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string path = ds.SaveToFileTextData(x);
double y;

using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
{
    y = reader.ReadDouble();

}

Console.WriteLine("* Y = " + y);

Console.WriteLine("***************************************************************************");
Console.ReadLine();

