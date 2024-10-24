using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path));
            double y;

            if (x == 0) y = -1;
            else y = Math.Round((x / (2 * x) + Math.Sin(Math.Pow(x, 2))), 3);

            return y;
        }
    }
}
