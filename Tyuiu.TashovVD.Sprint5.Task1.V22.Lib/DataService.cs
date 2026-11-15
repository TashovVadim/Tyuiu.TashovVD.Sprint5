using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;

namespace Tyuiu.TashovVD.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= startValue; x++)
            {
                double y = 0;
                if (x != startValue)
                {
                    if (x == 2)
                    {
                        File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
                    }
                    else
                    {
                        y = Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x));
                        y = Math.Round(y, 3);
                        File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
                    }
                }
                else
                {
                    if (x == 2)
                    {
                        File.AppendAllText(path, Convert.ToString(y));
                    }
                    else
                    {
                        y = Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x));
                        y = Math.Round(y, 3);
                        File.AppendAllText(path, Convert.ToString(y));
                    }
                }
                
                
            }
            return path;
        }
    }
}
