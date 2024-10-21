﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask0.txt");
           

            double temp = Math.Round(((x / (Math.Sqrt(Math.Pow(x, 2) + x)))), 3);

            File.WriteAllText(path, Convert.ToString(temp));

            return File.ReadAllText(path);
        }
    }
}
