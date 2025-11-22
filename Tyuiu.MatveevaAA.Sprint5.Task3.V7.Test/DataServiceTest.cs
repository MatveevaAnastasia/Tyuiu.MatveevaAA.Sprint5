using Tyuiu.MatveevaAA.Sprint5.Task3.V7.Lib;

namespace Tyuiu.MatveevaAA.Sprint5.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\nastya\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = false;

            Assert.AreEqual(wait, fileExists);
        }
    }
}