using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] _tempKey = keys;
            TValue[] _tempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                keys[i] = _tempKey[i];
                values[i] = _tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }

        public int Lenght
        {
            get { return keys.Length; }
        }

    }
}
