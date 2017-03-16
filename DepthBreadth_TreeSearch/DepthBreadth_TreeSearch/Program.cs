using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthBreadth_TreeSearch
{
    class Program
    {
        Graph graphy = new Graph();

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        public void Run()
        {
            graphy.DirectionalFillMatrix();


            //Deepth
            foreach (int item in graphy.TraverseDeepFirst(0))
            {
                Console.WriteLine((cities)item);
            }
            Console.WriteLine();
            graphy.CLear();
            //Breadth
            foreach (int item in graphy.TraverseBreadthFirst(0))
            {
                Console.WriteLine((cities)item);
            }

            Console.ReadKey();
        }
    }
}
