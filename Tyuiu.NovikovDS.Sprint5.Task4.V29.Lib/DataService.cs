using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            double y;

            string x = File.ReadAllText(path);
            x = x.Replace('.', ',');
            double temp = Convert.ToDouble(x);

            if (temp == 0) y = -1;
            else y = Math.Round((temp / (2 * temp) + Math.Sin(Math.Pow(temp, 2))), 3);

            return y;
        }
    }
}
