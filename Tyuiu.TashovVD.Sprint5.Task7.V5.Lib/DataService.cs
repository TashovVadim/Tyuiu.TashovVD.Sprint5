using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.TashovVD.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string str = null;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    str = line;
                }
            }
            string res = Regex.Replace(str, @"[a-zA-Z]", "");
            res = Regex.Replace(res, @" {2,}", " ");
            res = Regex.Replace(res, @" +([.,!?;:])", "$1");
            return res;
        }
    }
}
