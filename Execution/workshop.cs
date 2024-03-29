using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace sortingalgorithmWorkshop
{
  public class Node<T> where T : IComparable
  {
    public T Value;
    public Node<T> Next;

    public Node(T value)
    {
      this.Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
  }

  public class LinkedList<T> where T : IComparable
  {
    private Node<T> StartinNode;
    private Node<T> LastNode;
    private int Count;

    public LinkedList()
    {
      this.StartinNode = null;
      this.LastNode = null;
      this.Count = 0;
    }

    public void Print()
    {
      int counter = 0;
      Node<T> currentNode = this.StartinNode;

      while (currentNode != null)
      {
        Console.WriteLine("{0} -> {1}", counter, currentNode);

        counter = counter + 1;
        currentNode = currentNode.Next;
      }
    }

    public int Length()
    {
      return this.Count;
    }

    public void AddRange(T[] values)
    {
      foreach (T value in values)
      {
        this.Add(value);
      }
    }

    public void Add(T value)
    {
      Node<T> node = new Node<T>(value);

      if (this.StartinNode == null)
      {
        this.StartinNode = node;
        this.LastNode = node;
      }
      else
      {
        this.LastNode.Next = node;
        this.LastNode = node;
      }

      this.Count = this.Count + 1;
    }

    public Node<T> Get(T value)
    {
      Node<T> currentNode = this.StartinNode;

      while (currentNode != null)
      {
        if (currentNode.Value.Equals(value))
        {
          return currentNode;
        }

        currentNode = currentNode.Next;
      }

      return null;
    }

    public Node<T> Get(int index)
    {
      Node<T> currentNode = this.StartinNode;

      while (currentNode != null)
      {
        if (index <= 0)
        {
          return currentNode;
        }

        currentNode = currentNode.Next;
        index = index - 1;
      }

      return null;
    }
    public void insertionSort()
    {
      for (int index = 0; index < this.Count; index++)
      {
        T item = this.Get(index).Value;
        int orderedListIndex = index - 1;

        while (orderedListIndex >= 0 && this.Get(orderedListIndex).Value.CompareTo(item) > 0)
        {
          this.Get(orderedListIndex + 1).Value = this.Get(orderedListIndex).Value;
          orderedListIndex--;
        }
        this.Get(orderedListIndex + 1).Value = item;
      }
    }
    public void bubbleSort()
    {
      for (int index = 1; index < this.Count; index++)
      {
        for (int sortedIndex = index - 1; sortedIndex >= 0; sortedIndex--)
        {
          if (this.Get(sortedIndex).Value.CompareTo(this.Get(sortedIndex + 1).Value) > 0)
          {
            T item = this.Get(sortedIndex + 1).Value;
            this.Get(sortedIndex + 1).Value = this.Get(sortedIndex).Value;
            this.Get(sortedIndex).Value = item;
          }
        }
      }
    }
    public void MergeSort(int startIndex, int endIndex)
    {
      if (startIndex < endIndex)
      {
        int centerIndex = (startIndex + endIndex) / 2;
        MergeSort(startIndex, centerIndex);
        MergeSort(centerIndex + 1, endIndex);
        Merge(startIndex, centerIndex, centerIndex);
      }
    }
    public void Merge(int startIndex, int centerIndex, int endIndex)
    {
      int sizeLeftArray = centerIndex - startIndex + 1;
      int sizeRightArray = endIndex - centerIndex;

      int indexLeftArray = 0;
      int indexRightArray = 0;
      int indexMergedLinkedList = startIndex;

      T[] leftArray = new T[sizeLeftArray];
      T[] rightArray = new T[sizeRightArray];

      for (indexLeftArray = 0; indexLeftArray < sizeLeftArray; indexLeftArray++)
      {
        leftArray[indexLeftArray] = this.Get(startIndex + indexLeftArray).Value;
      }
      for (indexRightArray = 0; indexRightArray < sizeRightArray; indexRightArray++)
      {
        rightArray[indexRightArray] = this.Get(centerIndex + indexRightArray + 1).Value;
      }

      indexLeftArray = 0;
      indexRightArray = 0;

      while (indexLeftArray < sizeLeftArray && indexRightArray < sizeRightArray)
      {
        if (leftArray[indexLeftArray].CompareTo(rightArray[indexRightArray]) <= 0)
        {
          this.Get(indexMergedLinkedList).Value = leftArray[indexLeftArray];
          indexLeftArray++;
        }
        else
        {
          this.Get(indexMergedLinkedList).Value = rightArray[indexRightArray];
          indexRightArray++;
        }
        indexMergedLinkedList++;
      }
      while(indexLeftArray < sizeLeftArray)
      {
        this.Get(indexMergedLinkedList).Value = leftArray[indexLeftArray];
        indexLeftArray++;
        indexMergedLinkedList++;
      }
      while(indexRightArray < sizeRightArray)
      {
        this.Get(indexMergedLinkedList).Value = rightArray[indexRightArray];
        indexRightArray++;
        indexMergedLinkedList++;
      }
    }
  }
}