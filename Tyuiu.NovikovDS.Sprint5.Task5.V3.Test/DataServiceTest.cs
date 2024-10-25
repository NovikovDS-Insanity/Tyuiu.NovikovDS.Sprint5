using Tyuiu.NovikovDS.Sprint5.Task5.V3.Lib;

namespace Tyuiu.NovikovDS.Sprint5.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V3.txt");

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}