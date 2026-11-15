using Tyuiu.TashovVD.Sprint5.Task3.V27.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.Combine(@"C:\Users", "Vadimas", "AppData", "Local", "Temp", "OutPutFileTask3.txt");
            FileInfo fileInfo = new FileInfo(path);

            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
