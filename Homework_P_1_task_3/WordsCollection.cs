using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_1_task_3
{
    internal class WordsCollection : IEnumerable, IEnumerator
    {
        readonly WordsData[] word = new WordsData[7];
        int position = -1;

        public WordsData this[int index]
        {
            get { return word[index]; }
            set { word[index] = value; }
        }

        bool IEnumerator.MoveNext()
        {
            if (position < word.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset() { position = -1; }
        object IEnumerator.Current { get { return word[position]; } }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
