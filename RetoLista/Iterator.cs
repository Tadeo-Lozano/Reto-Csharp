using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoLista
{
    internal interface Iterator<T>
    {
        Boolean hasNext();
        T next();
    }
}
