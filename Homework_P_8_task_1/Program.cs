using System.Xml.Serialization;

namespace Homework_P_8_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users();
            users.UsersData.Add("player 1");
            users.UsersData.Add("player 2");
            users.UsersData.Add("player 3");
            users.UsersData.Add("player 4");

            XmlSerializer serializer = new XmlSerializer(typeof(Users));
            FileStream fileStream = new FileStream("Serealization.xml", FileMode.OpenOrCreate, FileAccess.Write);
            Console.WriteLine();
            serializer.Serialize(fileStream, users);
            fileStream.Close();

        }
    }
}