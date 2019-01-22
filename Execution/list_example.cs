using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace lists
{
  // Creating the type which contains the data
  public class Node<T> where T : IComparable
  {
    // The properties of each node
    public T Value;
    public Node<T> Next;
    // The constructor which adds the data to the node
    public Node(T value, Node<T> next)
    {
      Value = value;
      Next = next;
    }
  }
  // Creating the list
  public class SortedLinkedList<T> where T : IComparable
  {
    // The properties of the list
    public Node<T> Start;
  }
  class list_example
  {
    public static void callable()
    {
      var list = new SortedLinkedList<int>();  // instantiate a new list
      List_insert(list, 5);                    // Add data(int) to the list
      List_insert(list, 20);
      List_insert(list, 2);
      List_insert(list, 8);
      List_insert(list, 6);
      // var res = List_search(list, 1);       // Search for the node with a given value
      // Console.WriteLine(res.Value);
      List_delete(list, 15);
    }
    public static void List_delete(SortedLinkedList<int> list, int toDelete)
    {
      if (list.Start == null || list.Start.Value > toDelete)
      {
        // The given value is not in the list
        return;
      }
      else if (list.Start.Value == toDelete)
      {
        // The given value is the first in the list
        list.Start = list.Start.Next;
        return;
      }
      var temp = list.Start;
      while (temp.Next != null && temp.Next.Value <= toDelete)
      {
        if (temp.Next.Value == toDelete)
        {
          // setting the next node to the current node
          temp.Next = temp.Next.Next;
          return;
        }
        temp = temp.Next;
      }
      return;
    }
    public static Node<int> List_search(SortedLinkedList<int> list, int toFind)
    {
      var temp = list.Start;
      while (temp != null && temp.Value != toFind)
      {
        temp = temp.Next;
      }
      // if temp is not found
      if (temp == null)
      {
        // return a new node with no next node, and the minimum value
        return new Node<int>(int.MinValue, null);
      }
      // return the found node
      return temp;
    }
    public static void List_insert(SortedLinkedList<int> list, int toInsert)
    {
      if (list.Start == null || list.Start.Value > toInsert)
      {
        // Set the starting node
        list.Start = new Node<int>(toInsert, list.Start);
        return;
      }
      var x = list.Start;
      while (x.Next != null && x.Next.Value <= toInsert)
      {
        x = x.Next;
      }
      x.Next = new Node<int>(toInsert, x.Next);
      return;
    }
  }
}