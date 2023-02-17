using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_1_task_4
{
    internal class ArrayToCollection
    {
        int[] ints;
        int pos = -1;
        public ArrayToCollection(int[] ints) 
        {
            this.ints = ints;
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (pos < ints.Length - 1)
                {
                    pos++;
                    yield return ints[pos];
                }
                else
                {
                    pos = -1;
                    yield break;
                }
            }
        }
    }
}
