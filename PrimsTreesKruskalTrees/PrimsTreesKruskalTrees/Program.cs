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
            prims.DirectionalFillMatrix();
            //prims.NonDirectionalFillMatrix();

            foreach (int item in prims.PrimsTraverse(0))
            {
                Console.WriteLine((cities)item);
            }
            Console.ReadKey();
            foreach (string item in prims.rute)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public void TestKruskal()
        {
            kruskal.DirectionalFillMatrix();
            kruskal.NonDirectionalFillMatrix();

            foreach (int item in kruskal.KruskalTraverse()
            {
                Console.WriteLine((cities)item);
            }
            Console.ReadKey();
            foreach (string item in prims.rute)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    
}
