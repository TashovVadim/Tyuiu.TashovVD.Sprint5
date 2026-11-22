using Tyuiu.TashovVD.Sprint5.Task5.V19.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V19.txt");
            double wait = 15;
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
