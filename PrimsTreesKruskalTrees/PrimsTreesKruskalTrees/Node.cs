using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsTreesKruskalTrees
{
    class Node
    {
        public string name;
        public int index;
        public List<Edge> edges;
        public Node(string name, int index)
        {
            this.name = name;
            this.index = index;
            if (edges == null)
            {
                edges = new List<Edge>();
            }

        }
        public override string ToString()
        {
            return name + " Index: " + index + " ";
        }

    }
    
}
