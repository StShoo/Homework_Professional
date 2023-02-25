using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_7_task_2
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class MyAttribute: Attribute
    {
        private readonly string name;
        private int num;

        public MyAttribute(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
    }
}
