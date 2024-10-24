using System;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task3.V7.Lib
{
    public class DataService : ISprint5Task3V7
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = "OutPutFileTask3.bin";

            string path = Path.Combine(Path.GetTempPath(), outputFile);

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);

            double r = Math.Round((1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x), 3);

            using (BinaryWriter writer = new(File.Open(path, FileMode.Append)))
            {
                writer.Write(r);
            }
            return path;
        }
    }
}
