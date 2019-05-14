using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    struct KeyValue
    {
        public readonly string key;
        public readonly object value;


        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }
    
    class MyDictionary


    {
    KeyValue[] kvs = new KeyValue[16];
    interface storedValues = 0;

        public object this[string key]
        {
            set
            {
                bool found = false;

                for (int i = 0; i < storedValues; ++i)
                {
                    if (kvs[i].key == key)
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    kvs[storedValues++] = new KeyValue(key, value);
                }
            }

            get
            {
                bool found = false;
                for (int i = 0; i < storedValues; ++i)
                {
                    if (kvs[i].key == searchKey)
                        return kvs[i].value;
                }

                throw new KeyNotFoundException($"Didn't find\"{searchKey}\" in MyDictionary");
            }
           
        }
    }


    
}
