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
        List<Node> rute = new List<Node>();
       
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
        public List<Node> PrimsStart(string start)
        {
            foreach (Node node in nodeList)
            {
                if (start == node.name)
                {
                    return PrimsTraverse(node);
                }
            }
            return null;
        }
        private List<Node> PrimsTraverse(Node start)
        {
            visitedlocations.Add(start);

            while (visitedlocations.Count <= nodeList.Count)
            {
                Node location = null;
                int lowest = int.MaxValue; //til at finde den laveste edge værdi
                foreach (Node node in visitedlocations) //for hver location i vores liste
                {
                    foreach (Edge edge in node.edges) //for hver kant den location kan se
                    {
                        if (edge.weigth < lowest && !visitedlocations.Contains(edge.to)) //tjekker for om den er lavere end den tidligere fundne
                        {
                            lowest = edge.weigth;
                            location = edge.to;
                        }
                    }
                }
                if (lowest != int.MaxValue && location != null)
                {
                    visitedlocations.Add(location);
                }
                else
                {
                    return visitedlocations;
                }
            }
            return visitedlocations;
        }
    }
}
