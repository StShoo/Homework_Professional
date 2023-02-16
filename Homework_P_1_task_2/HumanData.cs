using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_1_task_2
{
    internal class HumanData
    {
        public string HumanName { get; set; }
        public int HumanAge { get; set; }
        public HumanData(string name, int age)
        {
            HumanName = name;
            HumanAge = age;
        }
    }
}
