using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int sum = 0;

            string str = File.ReadAllText(path);
            string[] chisla = str.Split(", ");

            for (int i = 0; i < chisla.Length; i++)
            {
                if (i == chisla.Length - 1) chisla[i] = chisla[i].Remove(chisla[i].Length-1);
                if (chisla[i].Length == 4) sum++;
                Console.WriteLine(chisla[i]);
            }

            return sum;
        }
    }
}
