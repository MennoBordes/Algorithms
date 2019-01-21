using System;
using System.Linq;

namespace Heaps
{
  class Heap_example
  {
    public static int Parent(int i)
    {
      return i / 2;
    }
    public static int Left(int i)
    {
      return 2 * i;
    }
    public static int Right(int i)
    {
      return 2 * i + 1;
    }
    public static void Max_heapify(int[] A, int index)
    {
      var l = Left(index);
      var r = Right(index);
      int largest;
      if (l <= A.Length && A[l] > A[index]) { largest = l; }
      else { largest = index; }

      if (r <= A.Length && A[r] > A[largest]) { largest = r; }
      if (largest != index)
      {
        A[index] = A[largest];
        Max_heapify(A, largest);
      }
    }
  }
}