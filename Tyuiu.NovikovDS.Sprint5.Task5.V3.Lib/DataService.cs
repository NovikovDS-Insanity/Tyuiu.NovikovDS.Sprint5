using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task5.V3.Lib
{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;

            string str = File.ReadAllText(path);
            string[] chisla = str.Split(',');

            for (int i = 0; i < chisla.Length; i++)
            {
                double temp = Convert.ToDouble(chisla[i]);
                sum += temp;
            }

            return sum;
        }
    }
}
