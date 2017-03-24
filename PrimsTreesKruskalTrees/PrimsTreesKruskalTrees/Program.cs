using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsTreesKruskalTrees
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
    class Program
    {
        Prims prims = new Prims();
        Kruskal kruskal = new Kruskal();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        public void Run()
        {
            //TestPrims();
            TestKruskal();
        }
        public void TestPrims()
        {
            DirectedFillPrims();
            //NonDirectedFillPrims();
            foreach (Node city in prims.PrimsStart("Odense"))
            {
                Console.WriteLine(city);
            }
            Console.ReadKey();
        }
        public void DirectedFillPrims()
        {
            prims.AddNode("Odense");
            prims.AddNode("Svendborg");
            prims.AddNode("Middelfart");
            prims.AddNode("Kerteminde");
            prims.AddNode("Otterup");
            prims.AddNode("Ringe");
            prims.AddNode("Nyborg");
            prims.AddNode("Bogense");
            prims.AddNode("Assens");

            prims.AddEdgeToNode("Odense", "Bogense", 49);
            prims.AddEdgeToNode("Bogense", "Middelfart", 38);
            prims.AddEdgeToNode("Middelfart", "Assens", 61);
            prims.AddEdgeToNode("Odense", "Middelfart", 67);
            prims.AddEdgeToNode("Assens", "Odense", 59);
            prims.AddEdgeToNode("Ringe", "Assens", 43);
            prims.AddEdgeToNode("Svendborg", "Ringe" , 56);
            prims.AddEdgeToNode("Svendborg", "Odense", 90);
            prims.AddEdgeToNode("Svendborg", "Nyborg", 45);
            prims.AddEdgeToNode("Nyborg", "Odense", 58);
            prims.AddEdgeToNode("Odense", "Kerteminde", 33);
            prims.AddEdgeToNode("Bogense", "Otterup", 53);
            prims.AddEdgeToNode("Otterup", "Odense", 22);
        }
        public void NonDirectedFillPrims()
        {
            prims.AddNode("Odense");
            prims.AddNode("Svendborg");
            prims.AddNode("Middelfart");
            prims.AddNode("Kerteminde");
            prims.AddNode("Otterup");
            prims.AddNode("Ringe");
            prims.AddNode("Nyborg");
            prims.AddNode("Bogense");
            prims.AddNode("Assens");

            prims.AddEdgeToNode("Odense", " Bogense", 49);
            prims.AddEdgeToNode("Bogense", "Middelfart", 38);
            prims.AddEdgeToNode("Middelfart", "Assens", 61);
            prims.AddEdgeToNode("Odense", "Middelfart", 67);
            prims.AddEdgeToNode("Assens", "Odense", 59);
            prims.AddEdgeToNode("Ringe", "Assens", 43);
            prims.AddEdgeToNode("Svendborg", "Ringe", 56);
            prims.AddEdgeToNode("Svendborg", "Odense", 90);
            prims.AddEdgeToNode("Svendborg", "Nyborg", 45);
            prims.AddEdgeToNode("Nyborg", "Odense", 58);
            prims.AddEdgeToNode("Odense", "Kerteminde", 33);
            prims.AddEdgeToNode("Bogense", "Otterup", 53);
            prims.AddEdgeToNode("Otterup", "Odense", 22);

            prims.AddEdgeToNode("Bogense", " Odense", 49);
            prims.AddEdgeToNode("Middelfart", "Bogense", 38);
            prims.AddEdgeToNode("Assens", "Middelfart", 61);
            prims.AddEdgeToNode("Middelfart", "Odense", 67);
            prims.AddEdgeToNode("Odense", "Assens", 59);
            prims.AddEdgeToNode("Assens", "Ringe", 43);
            prims.AddEdgeToNode("Ringe", "Svendborg", 56);
            prims.AddEdgeToNode("Odense", "Svendborg", 90);
            prims.AddEdgeToNode("Nyborg", "Svendborg", 45);
            prims.AddEdgeToNode("Odense", "Nyborg", 58);
            prims.AddEdgeToNode("Kerteminde", "Odense", 33);
            prims.AddEdgeToNode("Otterup", "Bogense", 53);
            prims.AddEdgeToNode("Odense", "Otterup", 22);
        }
        public void TestKruskal()
        {
            DirectedFillKruskal();
            //NonDirectedFillKruskal();
            foreach (Node city in kruskal.KruskalStart())
            {
                Console.WriteLine(city);
            }
            Console.ReadKey();
        }
        public void DirectedFillKruskal()
        {
            kruskal.AddNode("Odense");
            kruskal.AddNode("Svendborg");
            kruskal.AddNode("Middelfart");
            kruskal.AddNode("Kerteminde");
            kruskal.AddNode("Otterup");
            kruskal.AddNode("Ringe");
            kruskal.AddNode("Nyborg");
            kruskal.AddNode("Bogense");
            kruskal.AddNode("Assens");

            kruskal.AddEdgeToNode("Odense", "Bogense", 49);
            kruskal.AddEdgeToNode("Bogense", "Middelfart", 38);
            kruskal.AddEdgeToNode("Middelfart", "Assens", 61);
            kruskal.AddEdgeToNode("Odense", "Middelfart", 67);
            kruskal.AddEdgeToNode("Assens", "Odense", 59);
            kruskal.AddEdgeToNode("Ringe", "Assens", 43);
            kruskal.AddEdgeToNode("Svendborg", "Ringe", 56);
            kruskal.AddEdgeToNode("Svendborg", "Odense", 90);
            kruskal.AddEdgeToNode("Svendborg", "Nyborg", 45);
            kruskal.AddEdgeToNode("Nyborg", "Odense", 58);
            kruskal.AddEdgeToNode("Odense", "Kerteminde", 33);
            kruskal.AddEdgeToNode("Bogense", "Otterup", 53);
            kruskal.AddEdgeToNode("Otterup", "Odense", 22);
        }
        public void NonDirectedFillKruskal()
        {
            kruskal.AddNode("Odense");
            kruskal.AddNode("Svendborg");
            kruskal.AddNode("Middelfart");
            kruskal.AddNode("Kerteminde");
            kruskal.AddNode("Otterup");
            kruskal.AddNode("Ringe");
            kruskal.AddNode("Nyborg");
            kruskal.AddNode("Bogense");
            kruskal.AddNode("Assens");

            kruskal.AddEdgeToNode("Odense", " Bogense", 49);
            kruskal.AddEdgeToNode("Bogense", "Middelfart", 38);
            kruskal.AddEdgeToNode("Middelfart", "Assens", 61);
            kruskal.AddEdgeToNode("Odense", "Middelfart", 67);
            kruskal.AddEdgeToNode("Assens", "Odense", 59);
            kruskal.AddEdgeToNode("Ringe", "Assens", 43);
            kruskal.AddEdgeToNode("Svendborg", "Ringe", 56);
            kruskal.AddEdgeToNode("Svendborg", "Odense", 90);
            kruskal.AddEdgeToNode("Svendborg", "Nyborg", 45);
            kruskal.AddEdgeToNode("Nyborg", "Odense", 58);
            kruskal.AddEdgeToNode("Odense", "Kerteminde", 33);
            kruskal.AddEdgeToNode("Bogense", "Otterup", 53);
            kruskal.AddEdgeToNode("Otterup", "Odense", 22);

            kruskal.AddEdgeToNode("Bogense", " Odense", 49);
            kruskal.AddEdgeToNode("Middelfart", "Bogense", 38);
            kruskal.AddEdgeToNode("Assens", "Middelfart", 61);
            kruskal.AddEdgeToNode("Middelfart", "Odense", 67);
            kruskal.AddEdgeToNode("Odense", "Assens", 59);
            kruskal.AddEdgeToNode("Assens", "Ringe", 43);
            kruskal.AddEdgeToNode("Ringe", "Svendborg", 56);
            kruskal.AddEdgeToNode("Odense", "Svendborg", 90);
            kruskal.AddEdgeToNode("Nyborg", "Svendborg", 45);
            kruskal.AddEdgeToNode("Odense", "Nyborg", 58);
            kruskal.AddEdgeToNode("Kerteminde", "Odense", 33);
            kruskal.AddEdgeToNode("Otterup", "Bogense", 53);
            kruskal.AddEdgeToNode("Odense", "Otterup", 22);
        }
    }
    
}
