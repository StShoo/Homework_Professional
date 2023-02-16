using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_1_task_3
{
    internal class WordsData
    {
        public string WordUa { get; set; }
        public string WordEng { get; set; }
        public WordsData(string wordUa, string wordEng)
        {
            WordUa = wordUa;
            WordEng = wordEng;
        }
    }
}
