using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
// https://simpledevcode.wordpress.com/2015/07/07/hash-tables-tutorial-c-c-java/
namespace Hashers
{
  class cHashTable
  {
    class hashentry
    {
      int key;
      string data;
      public hashentry(int key, string data)
      {
        this.key = key;
        this.data = data;
      }
      public int getKey()
      {
        return key;
      }
      public string getData()
      {
        return data;
      }
    }
    const int maxSize = 10; // table size
    hashentry[] table;
    public cHashTable()
    {
      table = new hashentry[maxSize];
      for (int i = 0; i < maxSize; i++)
      {
        table[i] = null;
      }
    }
    public string retrieve(int key)
    {
      int hash = key % maxSize;
      while (table[hash] != null && table[hash].getKey() != key)
      {
        hash = (hash + 1) % maxSize;
      }
      if (table[hash] == null)
      {
        return "Nothing found!";
      }
      else
      {
          return table[hash].getData();
      }
    }

  }
}