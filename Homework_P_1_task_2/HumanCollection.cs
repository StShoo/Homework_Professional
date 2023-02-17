using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_1_task_2
{
    internal class HumanCollection : IEnumerable, IEnumerator
    {
        readonly int len;
        HumanData[]? humans;
        int position = -1;

        public HumanData this[int index]
        {
            get { return humans[index]; }
            set { humans[index] = value; }
        }

        public HumanCollection(int len)
        {
            this.len = len;
            humans = new HumanData[len];
        }

        bool IEnumerator.MoveNext()
        {
            if (position < humans.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset() { position = -1; }
        object IEnumerator.Current { get { return humans[position]; } }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
