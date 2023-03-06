using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_P_8_task_2
{
    [XmlRoot("PlayersData")]
    public class Users
    {
        private List<string> usersData = new List<string>();
        [XmlArray("ListOfPlayers")]
        [XmlArrayItem("Player")]
        public List<string> UsersData
        {
            get { return usersData; }
            set { usersData = value; }
        }
    }
}
