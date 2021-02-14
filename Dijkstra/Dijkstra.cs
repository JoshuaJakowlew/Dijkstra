using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    struct Vertex
    {
        public int Distance { get; set; }
        public bool Visited { get; set; }
        public Vertex(int distance, bool visited)
        {
            Distance = distance;
            Visited = visited;
        }

    }
    class Dijkstra
    {
        private int[,] Edges { get; set; }
        private Vertex[] Vertices { get; set; }

        public Dijkstra(int[,] edges)
        {
            Edges = edges;
            Vertices = Enumerable
                .Repeat(new Vertex(int.MaxValue, false), edges.GetLength(0))
                .ToArray();
        }

        public int[] FindBestRoute(int begin, int end)
        {
            Vertices[begin] = new(0, false);

            int minDistance, minIdx;
            do
            {
                (minDistance, minIdx) = ClosestUnvisitedVertex();

                // Если нашли непосещенную вершину ближе
                if (minIdx != int.MaxValue)
                {
                    UpdateDistance(minIdx, minDistance);
                    Vertices[minIdx].Visited = true;
                }
            } while (minIdx != int.MaxValue);

            return RestorePath(begin, end);
        }

        private (int, int) ClosestUnvisitedVertex()
        {
            int minIdx = int.MaxValue;
            int minDistance = int.MaxValue;
            for (int i = 0; i < Vertices.Length; ++i)
            {
                if (!Vertices[i].Visited && Vertices[i].Distance < minDistance)
                {
                    minDistance = Vertices[minIdx = i].Distance;
                }
            }

            return (minDistance, minIdx);
        }

        private void UpdateDistance(int minIdx, int minDistance)
        {
            for (int i = 0; i < Vertices.Length; ++i)
            {
                if (Edges[minIdx, i] != 0) // Если есть ребро
                {
                    int tempMin = minDistance + Edges[minIdx, i];
                    if (tempMin < Vertices[i].Distance)
                    {
                        Vertices[i].Distance = tempMin;
                    }
                }
            }
        }

        private int[] RestorePath(int begin, int end)
        {
            List<int> path = new(Vertices.Length);
            path.Add(end);

            int weight = Vertices[end].Distance;
            while (end != begin)
            {
                for (int i = 0; i < Vertices.Length; ++i)
                {
                    if (Edges[i, end] != 0) // Если есть ребро
                    {
                        int tempWeight = weight - Edges[i, end]; // Расстояние из предыдущей вершины
                        if (tempWeight == Vertices[i].Distance) // Если совпало с посчитанным - это предыдущая вершина
                        {
                            weight = tempWeight;
                            path.Add(end = i);
                        }
                    }
                }
            }

            path.Reverse();
            return path.ToArray();
        }
    }
}
