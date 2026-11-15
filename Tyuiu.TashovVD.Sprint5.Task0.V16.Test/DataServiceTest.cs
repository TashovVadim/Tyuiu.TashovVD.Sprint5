using System.Diagnostics;
using Tyuiu.TashovVD.Sprint5.Task0.V16.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.Combine(@"C:\Users", "Vadimas", "AppData", "Local", "Temp", "OutPutFileTask0.txt");
            FileInfo fileInfo = new FileInfo(path);

            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);

        }
    }
}
