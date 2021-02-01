using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<KeyType, ValueType>
    {
        KeyType[] _keyArray;
        ValueType[] _valueArray;

        public MyDictionary()
        {
            _keyArray = new KeyType[0];
            _valueArray = new ValueType[0];

        }
        public void Add(KeyType key, ValueType value)
        {
            KeyType[] _tempKeyArray = _keyArray;
            _keyArray = new KeyType[_keyArray.Length + 1];
            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
            }
            _keyArray[_keyArray.Length - 1] = key;



            ValueType[] _tempValueArray = _valueArray;
            _valueArray = new ValueType[_valueArray.Length + 1];
            for (int i = 0; i < _tempValueArray.Length; i++)
            {
                _valueArray[i] = _tempValueArray[i];
            }
            _valueArray[_valueArray.Length - 1] = value;


        }


        public KeyType[] Key
        {
            get { return _keyArray; }
        }
        public ValueType[] Value
        {
            get { return _valueArray; }
        }

    }
}