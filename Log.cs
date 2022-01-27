using System;
using System.IO;
using System.Text;

namespace Лаба_1_ПО
{
    class Log
    {
        static string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log"); // путь .Log
        public static int count=1; //счётчик для новых файлов
        public static void Write(string type, string mes)
        {
            string filename = Path.Combine(pathToLog, string.Format("{0:dd.MM.yyy}.log", DateTime.Now)); //название лог файла
            Writes(filename,type,mes);
        }
        public static void WriteElement(string type,string mes)
        {
            string filename = Path.Combine(pathToLog, string.Format("{0:dd.MM.yyy}_Элемент№"+count+".log", DateTime.Now)); //название лог файла
            Writes(filename, type, mes);
        }
        static void Writes(string fileName, string type, string mes)
        {
            object sync = new object(); //объект блокировки

            if (!Directory.Exists(pathToLog))
            {
                Directory.CreateDirectory(pathToLog); // создаем папку, если нужно
            }
            
            string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] [{1}] [{2}()] [{3}]\r\n", DateTime.Now, type, AppDomain.CurrentDomain.FriendlyName, mes);

            lock (sync)
            {
                File.AppendAllText(fileName, fullText, Encoding.GetEncoding("Windows-1251")); //добавление строки в лог файл
            }
        } //метод заполнения лог файла
    }
}