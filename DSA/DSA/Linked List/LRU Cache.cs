using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Linked_List
{
    internal class LRU_Cache
    {
        int capacity;
        Dictionary<int, int> dct = new Dictionary<int, int>();
        List<int> lt = new List<int>();
        public LRU_Cache(int cap)
        {
            capacity = cap;
        }

        public int Get(int key)
        {
            if(!dct.ContainsKey(key))
            {
                return -1;
            }
            lt.Remove(key);
            lt.Add(key);
            return dct[key];
        }
        public void put(int key ,int value)
        {
            if(dct.ContainsKey(key))
            {
                lt.Remove(key);
            }
            else if(lt.Count == capacity)
            {
                int old = lt[0];
                lt.RemoveAt(0);
                dct.Remove(old);
            }
            dct[key] = value;
            lt.Add(key);
        }
    }
}
