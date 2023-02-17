using System.Collections;

namespace Homework_P_2_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Firs method
            Dictionary<int, object> dict = new Dictionary<int, object>();

            dict.Add(1097832, "Company_1");
            dict.Add(1152342, "Company_2");
            dict.Add(1712123, "Company_3");
            dict.Add(1138232, "Company_4");

            foreach (var item in dict)
            {
                Console.WriteLine($"Account: {item.Key} Company Name: {item.Value}");
            }

            Console.WriteLine(new string('-', 20));

            // Second method
            Hashtable companyTable = new Hashtable();

            companyTable[1097832] = "Company_1";
            companyTable[1152342] = "Company_2";
            companyTable[1712123] = "Company_3";
            companyTable[1138232] = "Company_4";

            foreach (DictionaryEntry item in companyTable)
            {
                Console.WriteLine($"Account: {item.Key} Company Name: {item.Value}");
            }
        }
    }
}