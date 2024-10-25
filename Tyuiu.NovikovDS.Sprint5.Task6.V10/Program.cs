using Tyuiu.NovikovDS.Sprint5.Task6.V10.Lib;

DataService ds = new();

Console.Title = "Спринт #5 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл, в котором есть набор символьных данных.                       *");
Console.WriteLine("* Найти количество слов длиной четыре символа в заданной строке.          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V10.txt");

Console.WriteLine("* Путь файла: " + path);
Console.WriteLine("* Набор слов: " + File.ReadAllText(path));

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int count = ds.LoadFromDataFile(path);

Console.WriteLine("* Количество 4-символьных слов: " + count);

Console.WriteLine("***************************************************************************");
Console.ReadLine();

