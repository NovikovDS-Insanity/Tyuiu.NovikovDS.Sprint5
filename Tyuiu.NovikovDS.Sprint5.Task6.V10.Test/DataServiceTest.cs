using Tyuiu.NovikovDS.Sprint5.Task6.V10.Lib;

namespace Tyuiu.NovikovDS.Sprint5.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V10.txt");

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}