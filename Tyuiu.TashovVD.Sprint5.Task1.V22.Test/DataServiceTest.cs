using Tyuiu.TashovVD.Sprint5.Task1.V22.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.Combine(@"C:\Users", "Vadimas", "AppData", "Local", "Temp", "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);

            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
