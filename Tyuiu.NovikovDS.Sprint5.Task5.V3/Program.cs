using Tyuiu.NovikovDS.Sprint5.Task5.V3.Lib;

DataService ds = new();

Console.Title = "Спринт #5 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл, в котором есть набор значений. Найти сумму всех целых чисел   *");
Console.WriteLine("* в файле. Полученный результат вывести на консоль. У вещественных        *");
Console.WriteLine("* значений округлить до трёх знаков после запятой.                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V3.txt");

Console.WriteLine("* Путь файла: " + path);
Console.WriteLine("* Набор чисел: " + File.ReadAllText(path));

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double y = ds.LoadFromDataFile(path);

Console.WriteLine("* Сумма всех целых чисел: " + y);

Console.WriteLine("***************************************************************************");
Console.ReadLine();

