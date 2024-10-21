using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task1.V5.Lib
{
    public class DataService : ISprint5Task1V5
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            double temp;
            string strtemp;

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) File.Delete(path);

            for (int i = startValue; i <= stopValue; i++)
            {
                temp = Math.Round(5 - 3 * i + ((1 + Math.Sin(i)) / (2 * i - 0.5)), 2);
                if (2 * i - 0.5 == 0) temp = 0;

                strtemp = Convert.ToString(temp);

                if (i != stopValue) File.AppendAllText(path, strtemp + Environment.NewLine);
                else File.AppendAllText(path, strtemp);
            }
            return path;
        }
    }
}
