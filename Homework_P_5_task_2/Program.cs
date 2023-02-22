using System.Xml;
using System.Xml.XPath;

namespace Homework_P_5_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var telphoneBook = new XPathDocument("TelephoneBook.xml");
            XPathNavigator navigator = telphoneBook.CreateNavigator();

            XPathNodeIterator elements = navigator.Select("MyContacts/Contact/TelephoneNumber");
            foreach(var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}