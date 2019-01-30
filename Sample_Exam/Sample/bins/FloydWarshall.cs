using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Floyd
{
  class FloydCallable
  {
    public static void callable()
    {
      const int cst = 999;
      int[,] graph = {
                         { 0,   6,  cst, 11 },
                         { cst, 0,   4, cst },
                         { cst, cst, 0,   2 },
                         { cst, cst, cst, 0 }
                           };
      FloydWarshall.Floyd(graph, 4);
    }
  }
  class FloydWarshall
  {
    public const int cst = 999;
    private static void Print(int[,] distance, int verticesCount)
    {
      Console.WriteLine("Shortest distance between every pair of vertices:");
      for (int i = 0; i < verticesCount; i++)
      {
        for (int j = 0; j < verticesCount; j++)
        {
          if (distance[i, j] == cst)
          {
            Console.Write("---".PadLeft(7));
          }
          else
          {
            Console.Write(distance[i, j].ToString().PadLeft(7));
          }
        }
        Console.WriteLine();
      }
    }
    public static void Floyd(int[,] graph, int verticesCount)
    {
      int[,] distance = new int[verticesCount, verticesCount];
      for (int i = 0; i < verticesCount; i++)
      {
        for (int j = 0; j < verticesCount; j++)
        {
          distance[i, j] = graph[i, j];
        }
      }
      for (int k = 0; k < verticesCount; k++)
      {
        for (int i = 0; i < verticesCount; i++)
        {
          for (int j = 0; j < verticesCount; j++)
          {
            if (distance[i, k] + distance[k, j] < distance[i, j])
            {
              distance[i, j] = distance[i, k] + distance[k, j];
            }
          }
        }
      }
      Print(distance, verticesCount);
    }
  }
}