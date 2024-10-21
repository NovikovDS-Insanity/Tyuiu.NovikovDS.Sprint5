using Tyuiu.NovikovDS.Sprint5.Task0.V6.Lib;

namespace Tyuiu.NovikovDS.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "Users", "InSanity", "AppData", "Local", "Temp", "OutPutFileTask0.txt");

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}