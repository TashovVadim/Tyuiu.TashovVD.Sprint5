using Tyuiu.TashovVD.Sprint5.Task4.V5.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V5.txt");
            double wait = -127.963;
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
