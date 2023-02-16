using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_1_task_1
{
    internal class MonthsColection : IEnumerable, IEnumerator
    {
        readonly MonthData[] months = new MonthData[12];
        int position = -1;

        public MonthData this[int index]
        {
            get { return months[index]; }
            set { months[index] = value; }
        }

        bool IEnumerator.MoveNext()
        {
            if (position < months.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset() { position = -1; }
        object IEnumerator.Current { get { return months[position]; } }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
