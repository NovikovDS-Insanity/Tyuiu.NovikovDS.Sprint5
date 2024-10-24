using Tyuiu.NovikovDS.Sprint5.Task4.V29.Lib;

namespace Tyuiu.NovikovDS.Sprint5.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V29.txt");

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}