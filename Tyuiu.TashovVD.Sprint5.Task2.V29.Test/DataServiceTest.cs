using Tyuiu.TashovVD.Sprint5.Task2.V29.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.Combine(@"C:\Users", "Vadimas", "AppData", "Local", "Temp", "OutPutFileTask2.txt");
            FileInfo fileInfo = new FileInfo(path);

            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
