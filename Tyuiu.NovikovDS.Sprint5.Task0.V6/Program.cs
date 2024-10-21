using Tyuiu.NovikovDS.Sprint5.Task0.V6.Lib;

DataService ds = new();

Console.Title = "Спринт #5 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение X: ");
int x;
do
{
    x = Convert.ToInt32(Console.ReadLine());
    if (x == 0) Console.Write("Происходит деление на ноль, введите другое число: ");
} while (x == 0);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Ответ записан в файл.");
Console.WriteLine("Значение выражения: " + ds.SaveToFileTextData(x));

Console.WriteLine("***************************************************************************");
Console.ReadLine();

