using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsTreesKruskalTrees
{
    
    class Kruskal
    {
        List<int> vistedlocations = new List<int>();
        List<int> connectionTracker = new List<int>();
        List<int> edgesOfGraph = new List<int>();
        int[,] matrix;
        public Kruskal()
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
            vistedlocations.Clear();
            //visited = new bool[9];
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
        public List<int> KruskalTraverse()
        {
            int graph = 0;
            foreach (int location in matrix) //laver en liste med hver location for at holde styr på hvilke graph grupper de er i.
            {
                connectionTracker.Add(graph); //Hver index er en location, på hver punkt står hvilken gruppe de er i.
                graph++; //de starter i hver sin gruppe

            }
            for (int x = 0; x < matrix.Length; x++)
            {
                for (int y = 0; y < matrix.Length; y++)
                {
                    edgesOfGraph.Add(matrix[x, y]); //finder alle kanterne og lægger dem i en liste.
                }
            }
            edgesOfGraph.Sort();//sortere den liste bagefter.

            foreach (int edge in edgesOfGraph) // for hver kant i vores graph
            {
                //få de locations den binder sammens navne
                //check om de allerede er i samme graph set
                //hvis ikke kombiner de 2 set, og tilføj edgens locations til listen
 
            }


            return vistedlocations;
        }
        
    }
}
