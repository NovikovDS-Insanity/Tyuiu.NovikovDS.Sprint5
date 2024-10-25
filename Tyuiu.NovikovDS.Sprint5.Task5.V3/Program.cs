using Tyuiu.NovikovDS.Sprint5.Task5.V3.Lib;

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

