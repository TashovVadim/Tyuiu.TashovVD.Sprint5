using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TashovVD.Sprint5.Task6.V3.Lib
{
    public class DataService : ISprint5Task6V3
    {
        public int LoadFromDataFile(string path)
        {
            List<string> str = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    str = line.Split(' ').ToList();
                }
            }
            int cnt = 0;
            string str1 = string.Join("", str);
            for (int i = 0; i < str1.Length; i++)
            {
                try
                {
                    if ((Convert.ToChar(str1[i]) >= 'A' && Convert.ToChar(str1[i]) <= 'Z') || (Convert.ToChar(str1[i]) >= 'a' && Convert.ToChar(str1[i]) <= 'z'))
                    {
                        cnt++;
                    }
                }
                catch 
                {
                    continue;
                }

            }

            return cnt;
        }
    }
}
