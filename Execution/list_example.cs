using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace lists
{
  internal class Node{}
  class list_example
  {
    public static void list_search<T>(LinkedList<T> L, int k)
    {
      var p = L.First();
      Console.WriteLine(p);
      while (p.Value. != k && p != null)
      {
          p = p.next();
      }
    }
  }
}