using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovDS.Sprint5.Task2.V16.Lib
{
    public class DataService : ISprint5Task2V16
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");    

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists; 
            if (fileExists) File.Delete(path);

            string str = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0) matrix[i, j] = 0;
                    else matrix[i, j] = 1;

                    if (j != matrix.GetLength(1) - 1) str += matrix[i, j] + ";";
                    else str += matrix[i, j];
                }
                if (i != matrix.GetLength(0) - 1) File.AppendAllText(path, str + Environment.NewLine);
                else File.AppendAllText(path, str);

                str = "";
            }
            return path;
        }
    }
}
