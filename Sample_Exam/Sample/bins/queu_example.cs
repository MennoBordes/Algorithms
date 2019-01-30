using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ques
{
  class Queue_example
  {
    public static void callable()
    {
      Queue<int> queue= new Queue<int>();
      queue.Enqueue(3);
      queue.Enqueue(5);
      queue.Enqueue(1);
      var res5 = queue.Dequeue();
      var res4 = queue.Dequeue();
      queue.Enqueue(8);
      var res3 = queue.Dequeue();
      queue.Enqueue(2);
      queue.Enqueue(4);
      var res2 = queue.Dequeue();
      queue.Enqueue(7);
      var res1 = queue.Peek();
    }
  }
}