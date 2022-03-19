using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoLista
{
    internal class ArrayListIterator<T> : Iterator<T>
    {
        private arrayList<T> ArrayList;
        private int currentItem;

        public ArrayListIterator(arrayList<T> arrayList)
        {
            this.ArrayList = arrayList;
        }

        public bool hasNext()
        {
            return currentItem < ArrayList.getSize();
        }

        public T next()
        {
            T data = ArrayList.getAt(currentItem);

            currentItem++;

            return data;
        }
    }
}
