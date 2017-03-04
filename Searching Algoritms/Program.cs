using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    class Program
    {
        static void Main(string[] args)
        { 
            GraphBuilder graph = new GraphBuilder();
            DijkstraAlgorithm dijstra = new DijkstraAlgorithm();

            // Build dijstra algoritme graph 1
            var searchProblem1 = graph.BuildGraph1();

            // Build dijstra algoritme graph 2
            var searchProblem2 = graph.BuildGraph2();

            // Build BFS algoritme graph 1

            // Build DFS algoritme graph 1

            // Search using dijstra with graph 1
            dijstra.search(searchProblem1.root, searchProblem1.goal);

            // Search using dijstra with graph 2



            //DijkstraAlgorithm dij = new DijkstraAlgorithm();
            //DijkstraAlgorithm_second dij2 = new DijkstraAlgorithm_second();

            //// Build graph
            //var nodes = dij2.buildGraph();
            //var root = nodes[0]; var goal = nodes[1];

            //// Start searching using Uniform Cost Search
            //dij2.search(root, goal);
        }
    }
}

















// Breadth First Searching for Nodes
//BreadthFirstAlgorithm b = new BreadthFirstAlgorithm();
//Node root = b.BuildBFSGraph();

// Traverse in BFS
//Console.WriteLine("-----BFS Traverse----- \n");
//b.Traverse(root);

// Search for Node E in BFS
//Console.WriteLine("-----BFS Searching----- \n");
//Node nodeFound = b.BreadthFirstSearch(root, "C");
//Console.WriteLine(nodeFound + " Node found using BFS searching \n");

// Depth First Searching for Nodes
//DepthFirstAlgorithm d = new DepthFirstAlgorithm();
//Node vortex = d.BuildDFSGraph();

// Traverse in DFS
//Console.WriteLine("-----DFS Traverse----- \n");
//d.Traverse(vortex);

//vortex = d.BuildDFSGraph();

// Search for Node S in DFS
//Console.WriteLine("-----DFS Searching----- \n");
//nodeFound = d.DepthFirstSearch(vortex, "S");
//Console.WriteLine(nodeFound + " Node found using DFS searching \n \n");

