using Tyuiu.TashovVD.Sprint5.Task7.V5.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V5.txt");
            string wait = ", Мир! Это    .";
            DataService ds = new DataService();
            string res = ds.LoadDataAndSave(path);
            Assert.AreEqual(wait, res);
        }
    }
}
