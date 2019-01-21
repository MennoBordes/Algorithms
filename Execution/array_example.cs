using System;
using System.Linq;

namespace Arrays
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

    public static void merge_sort(int[] array)
    {
      // calls the sorting function with the outer bounds provided
      merge_sort(array, 0, array.Length - 1);
    }
    public static void merge_sort(int[] array, int low, int top)
    {
      if (low < top)
      {
        // create a middle from the sum of the low and the top
        int middle = (low + top) / 2;
        // recursively call itself
        merge_sort(array, low, middle);
        // recursively call itself
        merge_sort(array, middle + 1, top);
        // Call the merge function, providing positions
        Merge(array, low, middle, top);
      }
    }
    public static void Merge(int[] array, int left, int middle, int right)
    {
      var n1 = middle - left + 1;
      var n2 = right - middle;
      // create empty arrays with their amount set
      int[] LeftArray = new int[n1 + 1];
      int[] RightArray = new int[n2 + 1];
      // fill the left array with relevant data
      for (int i = 0; i < n1; i++)
      {
        LeftArray[i] = array[left + i];
      }
      // fill the right array with relevant data
      for (int j = 0; j < n2; j++)
      {
        RightArray[j] = array[middle + j + 1];
      }
      // set the final entry of the arrays to "infinite" 
      LeftArray[n1] = int.MaxValue;
      RightArray[n2] = int.MaxValue;

      int st = 0;
      int sn = 0;
      // only run for the amount of items present + 1
      for (int Loop = left; Loop < right + 1; Loop++)
      {
        // if the value at the index of the left array is lower than 
        // the value at the index of the right array
        if (LeftArray[st] <= RightArray[sn])
        {
          // set the value of the left array to the index of the main array
          array[Loop] = LeftArray[st];
          st++;
        }
        else
        {
          // set the value of the right array to the index of the main array
          array[Loop] = RightArray[sn];
          sn++;
        }
      }
    }
  }
}