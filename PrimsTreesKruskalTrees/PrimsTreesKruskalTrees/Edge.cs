using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsTreesKruskalTrees
{
    class Edge
    {
        public Node from;
        public Node to;
        public int weigth;

        public Edge(Node from, Node to, int weigth)
        {
            this.from = from;
            this.to = to;
            this.weigth = weigth;
        }
        public override string ToString()
        {
            return to.name + " with " + weigth + " ";
        }
    }
}
