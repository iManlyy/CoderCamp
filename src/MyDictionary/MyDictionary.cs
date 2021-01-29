using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<Tkey, Tvalue>
    {
        // arrays of keys and values
        Tkey[] _kArray;
        Tvalue[] _vArray;
        Tkey[] _kTempArray;
        Tvalue[] _vTempArray;

        public MyDictionary()
        {
            _kArray = new Tkey[0];
            _vArray = new Tvalue[0];
        }
        public void Add(Tkey key,Tvalue value)
        {
            _kTempArray = _kArray;
            _vTempArray = _vArray;
            _kArray = new Tkey[_kArray.Length + 1];
            _vArray = new Tvalue[_vArray.Length + 1];
            for (int i = 0; i < _vTempArray.Length; i++)
            {
                _kArray[i] = _kTempArray[i];
                _vArray[i] = _vTempArray[i];
            }

            _kArray[_kArray.Length - 1] = key;
            _vArray[_kArray.Length - 1] = value;
        }
    }
}
