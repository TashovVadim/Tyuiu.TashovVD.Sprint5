using Tyuiu.TashovVD.Sprint5.Task3.V27.Lib;

namespace Tyuiu.TashovVD.Sprint5.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); Console.Title = "Спринт #5 | Выполнил: Ташов В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Ташов В. Д. | АСОиУб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
            Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль.                 *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string res = ds.SaveToFileTextData(3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
