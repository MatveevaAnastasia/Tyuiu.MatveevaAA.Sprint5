using System.Diagnostics;
using Tyuiu.MatveevaAA.Sprint5.Task0.V21.Lib;

namespace Tyuiu.MatveevaAA.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\Users\parse\source\repos\Tyuiu.MatveevaAA.Sprint5\Tyuiu.MatveevaAA.Sprint5.Task0.V21\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}