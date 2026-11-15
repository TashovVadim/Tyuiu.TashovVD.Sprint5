using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TashovVD.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int[,] res = new int[matrix.GetLength(0), matrix.GetLength(1)];

            string path = $@"{Path.GetTempPath()}\OutPutFileTask2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        res[i,j] = 0;
                    }
                    else
                    {
                        res[i, j] = matrix[i, j];
                    }
                }
            }

            string str = "";

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    if (j != res.GetLength(1))
                    {
                        str += $"{res[i, j]};";
                    }
                    else
                    {
                        str += $"{res[i, j]}";
                    }
                }

                if (i != res.GetLength(0))
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }

            return path;
        }
    }
}
