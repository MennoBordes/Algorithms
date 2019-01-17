using System;
using execution;

namespace execution
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creating an array that has to be sorted
      int[] arr = new int[] { 9, 8, 7, 9, 8, 3, 5, 8, 6, 5, 4, 3, 2, 1 };
      // Calling the sorting function
      var result = array_example.insertion_sort(arr);
    }
  }
}
