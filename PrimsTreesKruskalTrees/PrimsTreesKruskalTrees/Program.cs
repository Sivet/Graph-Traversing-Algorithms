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
            TestPrims();
            //TestKruskal();
        }
        public void TestPrims()
        {
            DirectedFillPrims();
            prims.Print();
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
            prims.AddEdgeToNode("Odense", "kerteminde", 33);
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
            prims.AddEdgeToNode("kerteminde", "Odense", 33);
            prims.AddEdgeToNode("Otterup", "Bogense", 53);
            prims.AddEdgeToNode("Odense", "Otterup", 22);
        }
        //public void TestKruskal()
        //{
        //    kruskal.DirectionalFillMatrix();
        //    kruskal.NonDirectionalFillMatrix();

        //    foreach (int item in kruskal.KruskalTraverse()
        //    {
        //        Console.WriteLine((cities)item);
        //    }
        //    Console.ReadKey();
        //    foreach (string item in prims.rute)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadKey();
        //}
    }
    
}
