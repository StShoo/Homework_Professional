using System.Collections;
using System.Collections.Specialized;

namespace Homework_P_2_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderedDict = new OrderedDictionary();
            orderedDict["Item1"] = "milk";
            orderedDict["Item2"] = "milk";
            orderedDict["Item3"] = "not milk";

            Console.WriteLine($"Item1 and Item2: {orderedDict[0] == orderedDict[1]}");
            Console.WriteLine($"Item2 and Item3: {orderedDict[1] == orderedDict[2]}");
        }
    }
}