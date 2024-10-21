using Tyuiu.NovikovDS.Sprint5.Task2.V16.Lib;

namespace Tyuiu.NovikovDS.Sprint5.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "Users", "InSanity", "AppData", "Local", "Temp", "OutPutFileTask2.csv");

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}