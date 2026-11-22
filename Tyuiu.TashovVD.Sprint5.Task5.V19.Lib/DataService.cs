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
            List<string> lst = new List<string>();
            List<double> lst1 = new List<double>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {
                    lst = line.Replace('.', ',').Split(' ').ToList();
                }
            }
            foreach (string line in lst)
            {
                double obj = Convert.ToDouble(line);
                if (((obj < 10.0) && (obj > -10.0)) && (Convert.ToInt32(obj) == obj))
                {
                    lst1.Add(obj);
                }
            }
            mx = lst1.Max();
            mn = lst1.Min();
            res = mx - mn;

            return res;
        }
    }
}
