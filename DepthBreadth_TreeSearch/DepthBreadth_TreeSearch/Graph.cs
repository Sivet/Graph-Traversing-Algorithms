using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthBreadth_TreeSearch
{
    enum cities
    {
        Odense,
        Svendborg,
        Middelfart,
        Kerteminde,
        Otterup,
        Ringe,
        Nyborg,
        Bogense,
        Assens
    }
    class Graph
    {
        Queue<int> breadthQue;
        List<int> visitedlocations = new List<int>();
        bool[] visited = new bool[9];

        int[,] matrix;
        public Graph()
        {
            if (matrix == null)
            {
                matrix = new int[9, 9];
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        matrix[i, j] = -1;
                    }
                }
            }
        }
        public void DirectionalFillMatrix()
        {
            matrix[0, 2] = 67;
            matrix[0, 3] = 33;
            matrix[0, 7] = 49;
            matrix[1, 0] = 90;
            matrix[1, 5] = 56;
            matrix[1, 6] = 45;
            matrix[2, 8] = 61;
            matrix[4, 0] = 22;
            matrix[5, 8] = 43;
            matrix[6, 0] = 58;
            matrix[7, 4] = 67;
            matrix[7, 2] = 38;
            matrix[8, 0] = 59;
        }
        public void NonDirectionalFillMatrix()
        {
            DirectionalFillMatrix();
            matrix[2, 0] = 67;
            matrix[3, 0] = 33;
            matrix[7, 0] = 49;
            matrix[0, 1] = 90;
            matrix[5, 1] = 56;
            matrix[6, 1] = 45;
            matrix[8, 2] = 61;
            matrix[0, 4] = 22;
            matrix[8, 5] = 43;
            matrix[0, 6] = 58;
            matrix[4, 7] = 67;
            matrix[2, 7] = 38;
            matrix[0, 8] = 59;
        }
        public void CLear()
        {
            visitedlocations.Clear();
            visited = new bool[9];
        }
        public void AddDirectional(int startIndex, int slutIndex, int value)
        {
            matrix[startIndex, slutIndex] = value;
        }
        public void AddNondirectional(int index1, int index2, int value)
        {
            matrix[index1, index2] = value;
            matrix[index2, index1] = value;
        }
        public void Print()
        {
            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (k < 9)
                    {
                        Console.Write(matrix[i, j] + " , ");
                        k++;
                    }
                    else
                    {
                        k = 0;
                        Console.Write("\n");
                        Console.Write(matrix[i, j] + " , ");
                        k++;
                    }

                }
            }
        }
        public List<int> TraverseDeepFirst(int start)
        {
            RecursiveTraverseDeepFirst(start);
            return visitedlocations;
        }
        private void RecursiveTraverseDeepFirst(int location)
        {
            if (visited[location] == false)
            {
                visited[location] = true;
                visitedlocations.Add(location);
                for (int i = 0; i < 9; i++)
                {
                    if (matrix[location, i] != -1)
                    {
                        RecursiveTraverseDeepFirst(i);
                    }
                }
            }

        }
        public List<int> TraverseBreadthFirst(int start)
        {
            breadthQue = new Queue<int>();
            breadthQue.Enqueue(start);
            visitedlocations.Add(start);
            visited[start] = true;

            while (breadthQue.Count > 0)
            {
                int temp = breadthQue.Dequeue();
                for (int i = 0; i < 9; i++)
                {
                    if (matrix[temp, i] != -1)
                    {
                        if (visited[i] == false)
                        {
                            breadthQue.Enqueue(i);
                            visitedlocations.Add(i);
                            visited[i] = true;
                        }
                    }
                }
            }
            return visitedlocations;
        }
    }
}
