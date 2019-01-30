using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace stacks
{
  public interface StackInterface<T>
  {                                       // The main elements of the stack
    Boolean Push(T data);
    T Pop();
    T Peek();
    Boolean isEmpty();
    void PrintStack();
  }
  public class Stack<T> : StackInterface<T>
  {                                       // The items the stack contains
    static readonly int MAX = 1000;
    int top;
    T[] stack = new T[MAX];

    public bool isEmpty()                 // To check if the stack is empty or not
    {
      return (top <= 0);
    }

    public T Peek()                       // To look at the top element
    {
      if (top <= 0)
      {
        Console.WriteLine("Stack underflow");
        return default(T);
      }
      else
      {
        T value = stack[top - 1];
        return value;
      }
    }

    public T Pop()                        // To look at and remove the top element
    {
      if (top <= 0)
      {
        Console.WriteLine("Stack underflow");
        return default(T);
      }
      else
      {
        // -- before top so it will deduct before the data has been read 
        T value = stack[--top];
        return value;
      }
    }
    public bool Push(T data)              // To add an new element to the stack
    {
      if (top >= MAX)
      {
        Console.WriteLine("Stack full");
        return false;
      }
      else
      {
        // ++ after top so it will be executed after the data has been written
        stack[top++] = data;
        // top++;
        return true;
      }
    }
    public void PrintStack()              // To print all items in the stack
    {
      if (top < 0)
      {
        Console.WriteLine("Stack underflow");
        return;
      }
      else
      {
        // Going from the top of the stack back down to 0
        Console.WriteLine("Items in the stack are: ");
        for (int i = top - 1; i >= 0; i--)
        {
          Console.WriteLine(stack[i]);
        }
      }
    }
  }
  class stack_example
  {
    public static void callable()
    {
      Stack<int> integers = new Stack<int>();
      var r1 = integers.isEmpty();
      integers.Push(5);
      var r2 = integers.isEmpty();
      integers.Push(6);
      integers.Push(7);
      integers.Push(58);
      integers.Push(9);
      var i1 = integers.Peek();
      integers.Push(586);
      var i2 = integers.Pop();
      integers.Push(112);
      var i3 = integers.Peek();
      integers.PrintStack();

      Stack<string> strings = new Stack<string>();
      strings.Push("HottentottenTentenTentoonstelling");
      strings.Push("Broodbakker");
      strings.Push("Frietuur");
      var s1 = strings.Peek();
      strings.Push("Oliebollen");
      var s2 = strings.Pop();
      var s3 = strings.Peek();
      strings.Push("Gekte");
      strings.PrintStack();

      Stack<int> inter = new Stack<int>();
      inter.Push(3);
      inter.Push(5);
      inter.Push(1);
      inter.Pop();
      inter.Pop();
      inter.Push(8);
      inter.Pop();
      inter.Pop();
      inter.Push(2);
      inter.Push(4);
      inter.Pop();
      inter.Push(7);
      inter.PrintStack();
    }
  }
}