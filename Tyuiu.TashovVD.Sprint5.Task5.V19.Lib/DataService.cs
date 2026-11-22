using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TashovVD.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            double mx = 0;
            double mn = 0;
            double res = 0;
            var lst = new List<double>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {

                    lst.Add(Convert.ToDouble(line.Replace('.', ',')));
                }
            }
            mx = lst.Max();
            mn = lst.Min();
            res = Math.Abs(mx) - Math.Abs(mn);

            return res;
        }
    }
}
