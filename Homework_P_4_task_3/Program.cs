using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Homework_P_4_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegionInfo regionInfo = RegionInfo.CurrentRegion;
            CultureInfo newCulture = CultureInfo.CurrentCulture;

            StreamReader streamReader = new StreamReader("recipt.txt");
            string fileText = streamReader.ReadToEnd();
            streamReader.Close();

            Console.WriteLine("Current local:");
            Console.WriteLine(Regex.Replace(fileText, @"грн", regionInfo.CurrencyNativeName));

            Console.WriteLine(new string('-', 20));

            regionInfo = new RegionInfo("en-US");
            newCulture = CultureInfo.GetCultureInfo("en-US");

            Console.WriteLine("USA local:");
            Console.WriteLine(Regex.Replace(fileText, @"грн", regionInfo.CurrencyNativeName));
        }
    }
}