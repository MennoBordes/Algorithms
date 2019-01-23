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
  }
  public class Stack<T> : StackInterface<T>
  {                                       // The items the stack contains
    static readonly int MAX = 1000;
    int top;
    T[] stack = new T[MAX];

    public bool isEmpty()
    {
      return (top <= 0);
    }

    public T Peek()
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

    public T Pop()
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

    public bool Push(T data)
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

      Stack<string> strings = new Stack<string>();
      strings.Push("HottentottenTentenTentoonstelling");
      strings.Push("Broodbakker");
      strings.Push("Frietuur");
      var s1 = strings.Peek();
      strings.Push("Oliebollen");
      var s2 = strings.Pop();
      var s3 = strings.Peek();
      strings.Push("Gekte");
    }
  }
}