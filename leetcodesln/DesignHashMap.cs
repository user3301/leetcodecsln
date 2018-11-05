using System.Collections.Generic;

namespace leetcodesln
{
    public class MyHashMap
    {
        private List<int> storage { get; set; }
        /** Initialize your data structure here. */
    public MyHashMap() {
        storage = new List<int>(0);
    }
    
    /** value will always be non-negative. */
    public bool Put(int key, int value) {
        for (int i = 0; i < storage.Count; i+=2)
        {
            if(storage[i]==key)
            {
                storage[i+1] = value;
                return false;
            }
        }
        storage.Add(key);
        storage.Add(value);
            return true;
    }
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key) {
        for (int i = 0; i < storage.Count; i+=2)
        {
            if(storage[i]==key)
            {
                return storage[i+1];
            }
        }
        return -1;
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public bool Remove(int key) 
    {
        for (int i = 0; i < storage.Count; i+=2)
        {
            if(storage[i] == key)
            {
                var targetkey = storage[i];
                var targetvalue = storage[i+1];
                storage.Remove(targetkey);
                storage.Remove(targetvalue);
                    return true;
            }
        }
            return false;
    }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */