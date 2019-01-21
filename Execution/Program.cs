using System;
using System.Linq;

using Arrays;

namespace execution
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creating an array that has to be sorted
      int[] arr = new int[] { 3, 41, 52, 26, 38, 57, 9, 49 };
      // var result = array_example.insertion_sort(arr);            // Calling the sorting function
      // var result = array_example.reverse_insertion_sort(arr);    // Calling the reverse sorting function
      // var result = array_example.sequential_search(arr, 5);     // Calling the search function, which returns the index of the value
      // int[] arr2 = new int[] { 5, 6, 98, -5, 7, 3, 509, 9874 };
      // var result = array_example.merge_sort(arr, arr2);
      Console.WriteLine(string.Join(",", arr));
      array_example.merge_sort(arr);
      Console.WriteLine(string.Join(",", arr));
    }
  }
}
