using Tyuiu.NovikovDS.Sprint5.Task4.V29.Lib;

DataService ds = new();

Console.Title = "Спринт #5 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл, в котором есть вещественное значение.                         *");
Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле.            *");
Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трёх    *");
Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V29.txt");

Console.WriteLine("* Путь файла: " + path);
Console.WriteLine("* X = " + File.ReadAllText(path));

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double y = ds.LoadFromDataFile(path);

Console.WriteLine("* Y = " + y);

Console.WriteLine("***************************************************************************");
Console.ReadLine();

