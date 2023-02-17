using System.Collections;

namespace Homework_P_2_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new SortedList();
            var myReverseList = new SortedList(new DesendingComperer());

            myList["Lenovo"] = "value_1";
            myList["Asus"] = "value_2";
            myList["MSI"] = "value_3";
            myList["Aser"] = "value_4";

            foreach (DictionaryEntry item in myList)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
                myReverseList.Add(item.Key, item.Value);
            }

            Console.WriteLine(new string('-', 20));

            foreach (DictionaryEntry item in myReverseList)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }
        }

        class DesendingComperer : IComparer
        {
            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            public int Compare(object? x, object? y)
            {
                int result = comparer.Compare(y, x);
                return result;
            }
        }
    }
}