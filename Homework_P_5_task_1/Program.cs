using System.Xml;

namespace Homework_P_5_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("TelephoneBook.xml");
            Console.WriteLine(doc.InnerXml);
        }
    }
}