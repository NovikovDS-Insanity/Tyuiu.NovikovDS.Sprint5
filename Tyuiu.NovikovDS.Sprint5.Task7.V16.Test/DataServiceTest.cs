using Tyuiu.NovikovDS.Sprint5.Task7.V16.Lib;

namespace Tyuiu.NovikovDS.Sprint5.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V16.txt");

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}