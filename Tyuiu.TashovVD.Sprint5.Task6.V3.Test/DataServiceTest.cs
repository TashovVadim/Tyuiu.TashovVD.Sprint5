using Tyuiu.TashovVD.Sprint5.Task6.V3.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V3.txt");
            double wait = 21;
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
