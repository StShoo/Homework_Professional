using System.Xml.Serialization;

namespace Homework_P_8_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users();
            FileStream fileStream = new FileStream("Serealization.xml",FileMode.Open ,FileAccess.Read);
            XmlSerializer serializer= new XmlSerializer(typeof(Users));

            users = serializer.Deserialize(fileStream) as Users;

            for(int i = 0; i < users.UsersData.Count; i++)
            {
                Console.WriteLine($"Player name: {users.UsersData[i]}");
            }
        }
    }
}