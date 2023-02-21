using System.Globalization;
using System.Text.RegularExpressions;

namespace Homework_P_4_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("text.txt");

            string fileText = streamReader.ReadToEnd();
            streamReader.Close();


            fileText = Regex.Replace(fileText, @"пiд", "ГАВ");
            fileText = Regex.Replace(fileText, @"вiд", "ГАВ");
            fileText = Regex.Replace(fileText, @"бiля", "ГАВ");
            Console.WriteLine(fileText);

            StreamWriter streamWriter = new StreamWriter("text.txt");
            streamWriter.Write(fileText);
            streamWriter.Close();
        }
    }
}