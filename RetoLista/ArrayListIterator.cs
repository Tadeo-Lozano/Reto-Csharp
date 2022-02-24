using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoLista
{
    internal class ArrayListIterator
    {
        private arrayList ArrayList;
        private int currentItem;

        public ArrayListIterator(arrayList arrayList)
        {
            this.ArrayList = arrayList;
        }

        public bool hasNext()
        {
            return currentItem < ArrayList.getSize();
        }

        public String next()
        {
            String data = ArrayList.getAt(currentItem);

            currentItem++;

            return data;
        }
    }
}
