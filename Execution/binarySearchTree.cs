using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearch
{
  class binaryCallable
  {
    public static void callable()
    {
      BinaryTree<int> numTree = new BinaryTree<int>();
      numTree.Add(6);
      numTree.Add(9);
      numTree.Add(3);

      Node<int> findThree = numTree.Find(3);
      Console.WriteLine(findThree.getValue());
      numTree.Delete(18);
      numTree.Delete(3);
      numTree.Delete(6);
    }
  }
  class Node<T> where T : IComparable
  {
    private T value;
    private Node<T> left;
    private Node<T> right;
    public Node(T value)
    {
      this.value = value;
    }
    public Boolean hasChildren()
    {
      return this.getLeft() != null || this.getRight() != null;
    }
    public void setLeft(Node<T> left)
    {
      this.left = left;
    }
    public void setRight(Node<T> right)
    {
      this.right = right;
    }
    public T getValue()
    {
      return value;
    }
    public Node<T> getLeft()
    {
      return left;
    }
    public Node<T> getRight()
    {
      return right;
    }
  }
  class BinaryTree<T> where T : IComparable
  {
    private Node<T> TreeRoot;
    private int Count;

    public BinaryTree()
    {
      this.TreeRoot = null;
    }
    public int GetCount()
    {
      return this.Count;
    }
    public void Add(T value)
    {
      this.AddNode(new Node<T>(value));
    }
    public void AddNode(Node<T> node)
    {
      if(node == null)
      {
        return;
      }
      if (this.TreeRoot == null)
      {
        this.TreeRoot = node;
      }
      else
      {
        Node<T> currentNode = this.TreeRoot;
        while (currentNode != null)
        {
          if (currentNode.getValue().CompareTo(node.getValue()) > 0)
          {
            if (currentNode.getLeft() == null)
            {
              currentNode.setLeft(node);
              return;
            }
            currentNode = currentNode.getLeft();
          }
          else
          {
            if (currentNode.getRight() == null)
            {
              currentNode.setRight(node);
              return;
            }
            currentNode = currentNode.getRight();
          }
        }
      }
    }
    public Node<T> Find(T value)
    {
      Node<T> currentNode = this.TreeRoot;
      while (currentNode != null)
      {
        if (currentNode.getValue().Equals(value))
        {
          return currentNode;
        }
        if (currentNode.getValue().CompareTo(value) > 0)
        {
          currentNode = currentNode.getLeft();
        }
        else
        {
          currentNode = currentNode.getRight();
        }
        // currentNode = currentNode.getValue().CompareTo(value) > 0 ? currentNode.getLeft() : currentNode.getRight();
      }
      return null;
    }
    public void Delete(T value)
    {
      if (this.TreeRoot != null)
      {
        if (this.TreeRoot.getValue().Equals(value))
        {
          Node<T> rightNode = this.TreeRoot.getRight();
          this.TreeRoot = this.TreeRoot.getLeft();
          if (rightNode != null)
          {
            this.AddNode(rightNode);
            return;
          }
        }
        Node<T> currentNode = this.TreeRoot;
        while (currentNode != null && currentNode.hasChildren())
        {
          if (this.DeleteNode(currentNode, value))
          {
            return;
          }
          else
          {
            if (currentNode.getValue().CompareTo(value) > 0)
            {
              currentNode = currentNode.getLeft();
            }
            else
            {
              currentNode = currentNode.getRight();
            }
            // currentNode = currentNode.getValue().CompareTo(value) > 0 ? currentNode.getLeft() : currentNode.getRight();
          }
        }
      }
    }
    private Boolean DeleteNode(Node<T> currentNode, T value)
    {
      if (currentNode.getLeft() != null)
      {
        if (currentNode.getLeft().getValue().Equals(value))
        {
          Node<T> rightNode = currentNode.getLeft().getRight();
          currentNode.setLeft(currentNode.getLeft().getLeft());
          this.AddNode(rightNode);
          return true;
        }
      }
      if (currentNode.getRight() != null)
      {
        if (currentNode.getRight().getValue().Equals(value))
        {
          Node<T> rightNode = currentNode.getRight().getRight();
          currentNode.setRight(currentNode.getRight().getLeft());
          this.AddNode(rightNode);
          return true;
        }
      }
      return false;
    }
  }
}