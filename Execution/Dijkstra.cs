using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Dijkstra
{
  class dijkstraCallable
  {
    public static void callable()
    {
      int[,] graph = {
                      { 0, 6, 0, 0, 0, 50, 0, 9, 0 },
                      { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
                      { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
                      { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                      { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
                      { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
                      { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
                      { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
                    };
      dijkstra.DijkstraAlgo(graph,0,9);
    }
  }
  class dijkstra
  {
    public static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
    {
      int min = int.MaxValue;
      int minIndex = 0;
      for (int v = 0; v < verticesCount; v++)
      {
        if (shortestPathTreeSet[v] == false && distance[v] <= min)
        {
          min = distance[v];
          minIndex = v;
        }
      }
      return minIndex;
    }
    public static void Print(int[] distance, int verticesCount)
    {
      Console.WriteLine("Vertex Distance from source");
      for (int i = 0; i < verticesCount; i++)
      {
        Console.WriteLine("{0}\t  {1}", i, distance[i]);
      }
    }
    public static void DijkstraAlgo(int[,] graph, int source, int verticesCount)
    {
      int[] distance = new int[verticesCount];
      bool[] shortestPathTreeSet = new bool[verticesCount];
      for (int i = 0; i < verticesCount; i++)
      {
        distance[i] = int.MaxValue;
        shortestPathTreeSet[i] = false;
      }
      distance[source] = 0;
      for (int count = 0; count < verticesCount - 1; count++)
      {
        int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
        shortestPathTreeSet[u] = true;

        for (int v = 0; v < verticesCount; v++)
        {
          if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
          {
            distance[v] = distance[u] + graph[u, v];
          }
        }
        Print(distance, verticesCount);
      }
    }
  }
}
