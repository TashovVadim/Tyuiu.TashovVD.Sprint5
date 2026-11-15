using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;
using System.Text;

namespace Tyuiu.TashovVD.Sprint5.Task3.V27.Lib
{
    public class DataService : ISprint5Task3V27
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y = Math.Round(Math.Pow((x-1), 3*x + 1), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
