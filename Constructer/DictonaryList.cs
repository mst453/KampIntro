using System;
using System.Text;
using System.Collections.Generic;

namespace Constructer
{
    class DictonaryList<K,V>
    {
        K[] keys1;
        V[] values1;
        

        public DictonaryList()
        {
            keys1 = new K[0];
            values1 = new V[0];        

        }

        public void Add(K key,V value)
        {

            K[] tempKeys = keys1;
            V[] tempValues = values1;
            keys1 = new K[tempKeys.Length+1];
            values1 = new V[tempValues.Length+1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys1[i] = tempKeys[i];
                values1[i] = tempValues[i];
            }

            keys1[keys1.Length - 1] = key;
            values1[values1.Length - 1] = value;
            Console.WriteLine(key);


        }
    }
}
