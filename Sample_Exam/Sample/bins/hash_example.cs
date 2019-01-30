using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
// https://simpledevcode.wordpress.com/2015/07/07/hash-tables-tutorial-c-c-java/
namespace Hashers
{
  class hashCallable
  {
    public static void callable()
    {
      // var test = new cHashTable();
      // test.insert(1, "test1");
      // test.insert(2, "test2");
      // test.insert(3, "test3");
      // test.insert(0, "test4");
      // test.insert(7, "test5");
      // test.insert(6, "test6");
      // test.insert(4, "test7");
      // // test.remove(50);
      // test.quadraticHashInsert(50, "test8");
      // test.quadraticHashInsert(15, "test13");
      // test.quadraticHashInsert(16, "test12");
      // test.quadraticHashInsert(14, "test9");
      // test.doubleHashInsert(48, "test10");
      // test.doubleHashInsert(13, "test14");
      // test.doubleHashInsert(12, "test11");
      // test.print();

      var test = new opentable();
      test.insert(654,"Test1");
      test.insert(981,"Test2");
      test.insert(687,"Test3");
      test.insert(20,"Test4");
      test.insert(978,"Test5");
      test.insert(1,"Test6");
      test.insert(9504,"Test7");
      test.insert(987564,"Test8");
      test.insert(453,"Test9");
      test.insert(7862,"Test10");
      test.insert(12345,"Test11");
      test.insert(456453,"Test12");
      test.retrieve(687);
      test.remove(687);
      test.retrieve(687);
      test.print();
    }
  }
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
    const int maxSize = 18; // table size
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
    public void insert(int key, string data)
    {
      if (!checkOpenSpace()) // if no open spaces available
      {
        Console.WriteLine("Table is at full capacity!");
        return;
      }
      int hash = (key % maxSize);
      while (table[hash] != null && table[hash].getKey() != key)
      {
        hash = (hash + 1) % maxSize;
      }
      table[hash] = new hashentry(key, data);
    }
    private bool checkOpenSpace()
    {
      bool isOpen = false;
      for (int i = 0; i < maxSize; i++)
      {
        if (table[i] == null)
        {
          isOpen = true;
          break;
        }
      }
      return isOpen;
    }
    public bool remove(int key)
    {
      int hash = key % maxSize;
      while (table[hash] != null && table[hash].getKey() != key)
      {
        hash = (hash + 1) % maxSize;
      }
      if (table[hash] == null)
      {
        return false;
      }
      else
      {
        table[hash] = null;
        return true;
      }
    }
    public void print()
    {
      for (int i = 0; i < table.Length; i++)
      {
        if (table[i] == null && i <= maxSize)// if there are null entries
        {
          continue; // don't print, continue looping              
        }
        else
        {
          Console.WriteLine("{0}", table[i].getData());
        }
      }
    }
    public void quadraticHashInsert(int key, string data)
    {
      // quadratic probing method
      if (!checkOpenSpace())
      {
        Console.WriteLine("table is at full capacity!");
        return;
      }
      int j = 0;
      int hash = key % maxSize;
      while (table[hash] != null && table[hash].getKey() != key)
      {
        j++;
        hash = (hash + j * j) % maxSize;
      }
      if (table[hash] == null)
      {
        table[hash] = new hashentry(key, data);
        return;
      }
    }
    public void doubleHashInsert(int key, string data)
    {
      // double probing method
      if (!checkOpenSpace())
      {
        Console.WriteLine("table is at full capacity!");
        return;
      }
      int hashVal = hash1(key);
      int stepSize = hash2(key);
      while (table[hashVal] != null && table[hashVal].getKey() != key)
      {
        hashVal = (hashVal + stepSize * hash2(key)) % maxSize;
      }
      table[hashVal] = new hashentry(key, data);
      return;
    }
    private int hash1(int key)
    {
      return key % maxSize;
    }
    private int hash2(int key)
    {
      // must be non-zero, less than the array size, ideally odd
      return 5 - key % 5;
    }
  }
  class opentable
  {
    class hashnode
    {
      int key;
      string data;
      hashnode next;
      public hashnode(int key, string data)
      {
        this.key = key;
        this.data = data;
        next = null;
      }
      public int getkey()
      {
        return key;
      }
      public string getdata()
      {
        return data;
      }
      public void setNextNode(hashnode obj)
      {
        next = obj;
      }
      public hashnode getNextNode()
      {
        return this.next;
      }
    }
    hashnode[] table;
    const int size = 18;
    public opentable()
    {
      table = new hashnode[size];
      for (int i = 0; i < size; i++)
      {
        table[i] = null;
      }
    }
    public void insert(int key, string data)
    {
      hashnode nObj = new hashnode(key, data);
      int hash = key % size;
      while (table[hash] != null && table[hash].getkey() % size != key % size)
      {
        hash = (hash + 1) % size;
      }
      if (table[hash] != null && hash == table[hash].getkey() % size)
      {
        nObj.setNextNode(table[hash].getNextNode());
        table[hash].setNextNode(nObj);
        return;
      }
      else
      {
        table[hash] = nObj;
        return;
      }
    }
    public string retrieve(int key)
    {
      int hash = key % size;
      while (table[hash] != null && table[hash].getkey() % size != key % size)
      {
        hash = (hash + 1) % size;
      }
      hashnode current = table[hash];
      while (current.getkey() != key && current.getNextNode() != null)
      {
        current = current.getNextNode();
      }
      if (current.getkey() == key)
      {
        return current.getdata();
      }
      else
      {
        Console.WriteLine("entry not found!");
        return "nothing found!";
      }
    }
    public void remove(int key)
    {
      int hash = key % size;
      while (table[hash] != null && table[hash].getkey() % size != key % size)
      {
        hash = (hash + 1) % size;
      }
      hashnode current = table[hash];
      bool isRemoved = false;
      while (current != null)
      {
        if (current.getkey() == key)
        {
          table[hash] = current.getNextNode();
          Console.WriteLine("entry removed succesfully!");
          isRemoved = true;
          break;
        }
        if (current.getNextNode() != null)
        {
          if (current.getNextNode().getkey() == key)
          {
            hashnode newNext = current.getNextNode().getNextNode();
            current.setNextNode(newNext);
            Console.WriteLine("entry removed succesfully!");
            isRemoved = true;
            break;
          }
          else
          {
            current = current.getNextNode();
          }
        }
      }
      if (!isRemoved)
      {
        Console.WriteLine("nothing found to delete!");
        return;
      }
    }
    public void print()
    {
      hashnode current = null;
      for (int i = 0; i < size; i++)
      {
        current = table[i];
        while (current != null)
        {
          Console.Write(current.getdata() + " ");
          current = current.getNextNode();
        }
        Console.WriteLine();
      }
    }
  }
}