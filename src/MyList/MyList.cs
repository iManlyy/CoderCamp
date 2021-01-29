using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Length
        {
            get { return _array.Length; }
        }
    }
}
