using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsTreesKruskalTrees
{
    
    class Kruskal
    {

        List<Node> nodeList = new List<Node>();

        List<Node> visitedlocations = new List<Node>();
        List<Node> connectionTracker = new List<Node>();
        List<Edge> edgesOfGraph = new List<Edge>();

        public void AddNode(string name)
        {
            Node node = new Node(name, nodeList.Count);
            nodeList.Add(node);
        }
        public void AddEdgeToNode(string from, string to, int weigth)
        {
            foreach (Node fromNode in nodeList)
            {
                if (from == fromNode.name)
                {
                    foreach (Node toNode in nodeList)
                    {
                        if (to == toNode.name)
                        {
                            Edge newEdge = new Edge(fromNode, toNode, weigth);
                            fromNode.edges.Add(newEdge);
                        }
                    }
                }
            }

        }
        public void CLear()
        {
            visitedlocations.Clear();
        }
        public void Print()
        {
            for (int i = 0; i < nodeList.Count; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(nodeList[i]);
                for (int j = 0; j < nodeList[i].edges.Count; j++)
                {
                    Console.WriteLine("Can see: " + nodeList[i].edges[j]);
                }
            }
        }
        public List<Node> KruskalStart()
        {
            foreach (Node city in nodeList) //Goes through all nodes
            {
                foreach (Edge edge in city.edges) //For every node goes through their edges
                {
                    if (!edgesOfGraph.Contains(edge)) //If the edge is not already in the list
                    {
                        edgesOfGraph.Add(edge); //Add the edge to the list of edges
                    }
                }

            }
            edgesOfGraph.Sort((x, y) => x.weigth.CompareTo(y.weigth)); //Sorts the list in ascending order
            return KruskalTraverse();
        }
        private List<Node> KruskalTraverse()
        {
            
            return visitedlocations;
        }








        //List<int> vistedlocations = new List<int>();
        //List<int> connectionTracker = new List<int>();
        //List<int> edgesOfGraph = new List<int>();
        //int[,] matrix;
        
        //public List<int> KruskalTraverse()
        //{
        //    int graph = 0;
        //    foreach (int location in matrix) //laver en liste med hver location for at holde styr på hvilke graph grupper de er i.
        //    {
        //        connectionTracker.Add(graph); //Hver index er en location, på hver punkt står hvilken gruppe de er i.
        //        graph++; //de starter i hver sin gruppe

        //    }
        //    for (int x = 0; x < matrix.Length; x++)
        //    {
        //        for (int y = 0; y < matrix.Length; y++)
        //        {
        //            edgesOfGraph.Add(matrix[x, y]); //finder alle kanterne og lægger dem i en liste.
        //        }
        //    }
        //    edgesOfGraph.Sort();//sortere den liste bagefter.

        //    foreach (int edge in edgesOfGraph) // for hver kant i vores graph
        //    {
        //        //få de locations den binder sammens navne
        //        //check om de allerede er i samme graph set
        //        //hvis ikke kombiner de 2 set, og tilføj edgens locations til listen

        //    }


        //    return vistedlocations;
        //}

    }
}
