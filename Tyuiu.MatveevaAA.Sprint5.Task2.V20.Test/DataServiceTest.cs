using Tyuiu.MatveevaAA.Sprint5.Task2.V20.Lib;

namespace Tyuiu.MatveevaAA.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            string direct = System.IO.Path.GetTempPath();



            string path = Path.GetTempFileName();
            string apath = Path.Combine(direct, path);

            FileInfo fileInfo = new FileInfo(apath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}