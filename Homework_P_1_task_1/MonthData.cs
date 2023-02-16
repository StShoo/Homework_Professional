using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_1_task_1
{
    internal class MonthData
    {
        public string MonthName { get; set; }
        public int MonthDays { get; set; }
        public MonthData(string monthName, int monthDays)
        {
            MonthName = monthName;
            MonthDays = monthDays;
        }
    }
}
