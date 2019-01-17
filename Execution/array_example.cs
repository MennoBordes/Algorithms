using System;

namespace execution
{
  class array_example
  {
    public static int[] insertion_sort(int[] A)
    {
      Console.WriteLine("The order before sorting: " + string.Join(",", A));
      // Loop through for the amount of entries in the table
      for (int j = 1; j < A.Length; j++)
      {
        // Set key to the current value A
        var key = A[j];
        // Set compare to the index of the value before key
        int compare = j - 1;
        // Keep looping until either
        //  1: compare is below 0
        //  2: the value of compare is smaller than the value of the key
        while (compare >= 0 && A[compare] > key)
        {
          // Move the smaller value to the end of the array
          A[compare + 1] = A[compare];
          compare = compare - 1;
        }
        // Insert the value of key in the location above compare
        A[compare + 1] = key;
      }
      Console.WriteLine("The order after sorting: " + string.Join(",", A));
      return A;
    }

    public static int[] reverse_insertion_sort(int[] A)
    {
      // Calling the sorting function
      insertion_sort(A);
      // Reversing the output
      Array.Reverse(A);
      Console.WriteLine("The order after reversing the sort: " + string.Join(",", A));
      return A;
    }

    public static int sequential_search(int[] A, int toCheck)
    {
      // Loop for the amount of items in the array 
      for (int i = 0; i < A.Length; i++)
      {
        // If the current item matches the search
        if (A[i] == toCheck)
        {
          // Return the index
          return i;
        }
      }
      // Return -1 as error code
      return -1;
    }
  }
}