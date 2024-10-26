using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);
            string[] slovo = str.Split(' ');

            string temp = "";
            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i].Length == 2) slovo[i] = "XY";

                if (i != slovo.Length - 1) temp += slovo[i] + ' ';
                else temp += slovo[i];
            }

            string OutPut = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V16.txt");

            FileInfo fileInfo = new(OutPut);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(OutPut);

            File.AppendAllText(OutPut, temp);

            return OutPut;
        }
    }
}
