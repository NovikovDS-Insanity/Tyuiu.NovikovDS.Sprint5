using Tyuiu.NovikovDS.Sprint5.Task7.V16.Lib;

DataService ds = new();

Console.Title = "Спринт #5 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проетов по спринту                  *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл, в котором есть набор символьных данных.Заменить все слова     *");
Console.WriteLine("* длиной 2 символа на слово \"XY\".Полученный результат сохранить в файл. *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V16.txt");

Console.WriteLine("* Путь файла: " + path);
Console.WriteLine("* Начальная строка:\n* " + File.ReadAllText(path));

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string OutPut = ds.LoadDataAndSave(path);
Console.WriteLine("* Преобразованная строка:\n* " + File.ReadAllText(OutPut));

Console.WriteLine("***************************************************************************");
Console.ReadLine();

