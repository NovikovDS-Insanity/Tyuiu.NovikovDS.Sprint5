using Tyuiu.NovikovDS.Sprint5.Task1.V5.Lib;

namespace Tyuiu.NovikovDS.Sprint5.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "Users", "InSanity", "AppData", "Local", "Temp", "OutPutFileTask1.txt");

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}