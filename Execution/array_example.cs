using System;

namespace execution
{
  class array_example
  {
    public static int[] insertion_sort(int[] A)
    {
      Console.WriteLine(string.Join(",", A));
      for (int j = 1; j < A.Length; j++)
      {
        var key = A[j];
        int compare = j - 1;
        while (compare >= 0 && A[compare] > key)
        {
          A[compare + 1] = A[compare];
          compare = compare - 1;
        }
        A[compare + 1] = key;
      }
      Console.WriteLine(string.Join(",", A));
      return A;
    }
  }
}