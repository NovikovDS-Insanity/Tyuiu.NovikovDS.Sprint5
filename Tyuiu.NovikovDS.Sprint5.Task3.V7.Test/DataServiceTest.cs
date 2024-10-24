using Tyuiu.NovikovDS.Sprint5.Task3.V7.Lib;

namespace Tyuiu.NovikovDS.Sprint5.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "Users", "InSanity", "AppData", "Local", "Temp", "OutPutFileTask3.bin");

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}