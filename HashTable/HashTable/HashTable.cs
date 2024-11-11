using System;

namespace HashTab
{
    class HashT
    {
        public string[] _hashTable;

        public HashT()
        {
            _hashTable = new string[10];
        }

        //This is a VERY VERY weak hashing algorithm
        private int _hash(string key)
        {
            return key.Length % _hashTable.Length;
        }

        public string Get(string key)
        {
            int hashedKey = _hash(key);
            return _hashTable[hashedKey];
        }
        public void Set(string key, string value)
        {
            //Key is going to be hashed
            int hashedKey = _hash(key);
            if(_hashTable[hashedKey] != null)
            {
                Console.WriteLine("Sorry, hash collision has occured");
            }
            else
            {
                _hashTable[hashedKey] = value;
            }
        }
    }
}