using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task5.V3.Lib
{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;

            string str = File.ReadAllText(path);
            string[] chisla = str.Split(' ');

            for (int i = 0; i < chisla.Length; i++)
            {
                chisla[i] = chisla[i].Replace(".", ",");

                double temp = Math.Round(Convert.ToDouble(chisla[i]), 3);
                if (temp % 1 == 0) sum += temp;
            }
            
            return sum;
        }
    }
}
