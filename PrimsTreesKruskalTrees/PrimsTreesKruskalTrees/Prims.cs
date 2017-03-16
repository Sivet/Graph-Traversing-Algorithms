using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsTreesKruskalTrees
{

    class Prims
    {
        List<Node> nodeList = new List<Node>();
        
        List<Node> visitedlocations = new List<Node>();
        public Node[] rute;
       
        public void AddNode(string name)
        {
            Node node = new Node(name, nodeList.Count);
            nodeList.Add(node);
            //matrix[0, 2] = 67;
            //matrix[0, 3] = 33;
            //matrix[0, 7] = 49;
            //matrix[1, 0] = 90;
            //matrix[1, 5] = 56;
            //matrix[1, 6] = 45;
            //matrix[2, 8] = 61;
            //matrix[4, 0] = 22;
            //matrix[5, 8] = 43;
            //matrix[6, 0] = 58;
            //matrix[7, 4] = 67;
            //matrix[7, 2] = 38;
            //matrix[8, 0] = 59;
        }
        public void AddEdgeToNode(Node from, Node to, int weigth)
        {
            Edge newEdge = new Edge(from, to, weigth);
            foreach (Node node in nodeList)
            {
                if (from.name == node.name)
                {
                    node.edges.Add(newEdge);
                }
            }

            //DirectionalFillMatrix();
            //matrix[2, 0] = 67;
            //matrix[3, 0] = 33;
            //matrix[7, 0] = 49;
            //matrix[0, 1] = 90;
            //matrix[5, 1] = 56;
            //matrix[6, 1] = 45;
            //matrix[8, 2] = 61;
            //matrix[0, 4] = 22;
            //matrix[8, 5] = 43;
            //matrix[0, 6] = 58;
            //matrix[4, 7] = 67;
            //matrix[2, 7] = 38;
            //matrix[0, 8] = 59;
        }
        public void CLear()
        {
            visitedlocations.Clear();
           
        }
        public void Print()
        {
            //int k = 0;
            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        if (k < 9)
            //        {
            //            Console.Write(matrix[i, j] + " , ");
            //            k++;
            //        }
            //        else
            //        {
            //            k = 0;
            //            Console.Write("\n");
            //            Console.Write(matrix[i, j] + " , ");
            //            k++;
            //        }

            //    }
            //}
        }

        public List<int> PrimsTraverse(int start)
        {
            //rute = new string[9];
            //visitedlocations.Add(start);
            
            //while (visitedlocations.Count < 9)
            //{
            //    int index = 0;
            //    found:

            //    int from = -1; //bare til at udskrive ruten
            //    int to = -1; //bare til at udskrive ruten

            //    int location = -1;
            //    int lowest = int.MaxValue;

            //    for (int x = 0; x < visitedlocations.Count; x++) //for hver location i vores liste
            //    {
            //        for (int y = 0; y < 9; y++) //hver af dem har 9 y værdier, eller potentielle steder den kan se
            //        {
            //            if (matrix[visitedlocations[x], y] != -1 && !visitedlocations.Contains(y) && matrix[visitedlocations[x], y] < lowest)
            //            { //hvis matixen ikke indeholder -1 på den plads, og x's y ikke er besøgt før, og x's y er den mindste y

            //                lowest = matrix[visitedlocations[x], y]; //set den nye laveste værdi
            //                from = visitedlocations[x]; //bare til at udskrive ruten
            //                to = y; //bare til at udskrive ruten
            //                location = y; //set den nye location så den kan sættes som besøgt
            //            }
            //        }
            //    }
            //    if (lowest < int.MaxValue && location != -1) //hvis en lowest er blevet fundet, og location findes.
            //    {
            //        visitedlocations.Add(location); //tilføj location så den bliver husket som besøgt
            //        rute[index] = from.ToString() + " " + to.ToString();
            //        index++;
            //        goto found;
            //    }
            //    break;
            //}

            //return visitedlocations;

        }
        
    }
}
