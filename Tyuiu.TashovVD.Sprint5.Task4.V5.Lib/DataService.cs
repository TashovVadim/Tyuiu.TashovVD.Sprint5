using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TashovVD.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            var val = File.ReadAllText(path);
            val = val.Replace('.', ',');
            double res = ((4.26*(Convert.ToDouble(val))) / (Math.Sin(Convert.ToDouble(val))));
            return Math.Round(res, 3);
        }
    }
}
