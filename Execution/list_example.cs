using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace lists
{
  public class DoubleLinkedNode<T>
  {
    public DoubleLinkedNode<T> Prev;
    public DoubleLinkedNode<T> Next;
    public T Data;
    public DoubleLinkedNode(DoubleLinkedNode<T> prev, DoubleLinkedNode<T> next, T value)
    {
      Prev = prev;
      Next = next;
      Data = value;
    }
  }

  public class DoubleLinkedList<T>
  {
    public DoubleLinkedNode<T> FirstNode;
    public DoubleLinkedNode<T> LastNode;
  }
  class double_list_example
  {
    public static void callable()
    {
      var list = new DoubleLinkedList<int>();   // Initiate a new Double linked list
      InsertBeginning(list, 50);                // Insert values at the beginning
      InsertBeginning(list, 15);
      InsertBeginning(list, 5);
      InsertLast(list, 55);                     // Insert values at the end
      InsertLast(list, 80);
      // Remove(list, 15);                         // Remove a certain value
      var res = search(list, 50);
      // InsertBefore(list, res, 20);
      InsertAfter(list, res, 51);
      InsertAfter(list, res, 15);
    }
    public static void InsertAfter<T>(DoubleLinkedList<T> list, DoubleLinkedNode<T> node, T newValue)
    {
      if (node == null)
      {
        return;
      }
      if (list.LastNode == null || list.LastNode == node)
      {
        InsertLast(list, newValue);
      }
      var temp = list.FirstNode;
      while (temp.Next != null)
      {
        if (temp.Next == node)
        {
          var place = temp.Next.Next;
          place = new DoubleLinkedNode<T>(place.Prev, place, newValue);
          place.Prev.Next = place;
          place.Next.Prev = place;
          return;
        }
        temp = temp.Next;
      }
      return;
    }
    public static void InsertBefore<T>(DoubleLinkedList<T> list, DoubleLinkedNode<T> node, T newValue)
    {
      if (node == null) { return; }
      if (list.FirstNode == null || list.FirstNode == node)
      {
        InsertBeginning(list, newValue);
      }
      var temp = list.FirstNode;
      while (temp.Next != null)
      {
        if (temp.Next == node)
        {
          var current = temp;
          temp = new DoubleLinkedNode<T>(current, temp.Next, newValue);
          temp.Next.Prev = temp;
          temp.Prev.Next = temp;
          return;
        }
        temp = temp.Next;
      }
      return;
    }
    public static DoubleLinkedNode<T> search<T>(DoubleLinkedList<T> list, T value)
    {
      var node = list.FirstNode;
      while (node != null)
      {
        if (node.Data.Equals(value))
        {
          return node;
        }
        node = node.Next;
      }
      return null;
    }
    public static void Remove<T>(DoubleLinkedList<T> list, T value)
    {
      if (list.FirstNode == null)
      {
        return;
      }
      else if (list.FirstNode.Data.Equals(value))
      {
        list.FirstNode = list.FirstNode.Next;
      }
      var temp = list.FirstNode;
      while (temp.Next != null)
      {
        if (temp.Next.Data.Equals(value))
        {
          temp.Next = temp.Next.Next;
          return;
        }
        temp = temp.Next;
      }
      return;
    }
    public static void InsertBeginning<T>(DoubleLinkedList<T> list, T newValue)
    {
      if (list.FirstNode == null)
      {
        list.FirstNode = list.LastNode = new DoubleLinkedNode<T>(null, null, newValue);
      }
      else
      {
        var current = list.FirstNode;
        list.FirstNode = new DoubleLinkedNode<T>(current.Prev, current, newValue);
        current.Prev = list.FirstNode;
      }
    }
    public static void InsertLast<T>(DoubleLinkedList<T> list, T newValue)
    {
      if (list.LastNode == null)
      {
        list.LastNode = list.FirstNode = new DoubleLinkedNode<T>(null, null, newValue);
      }
      else
      {
        var current = list.LastNode;
        list.LastNode = new DoubleLinkedNode<T>(current, current.Next, newValue);
        current.Next = list.LastNode;
      }
    }
  }

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
  class single_list_example
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