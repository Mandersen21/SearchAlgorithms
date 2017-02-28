using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class DijkstraAlgorithm
    {
        public Node buildGraph()
        {
            Node A = new Node("A", false);
            Node B = new Node("B", false);
            Node C = new Node("C", false);
            Node D = new Node("D", false);
            Node E = new Node("E", false);

            // Add neighbors to all nodes
            A.neighbors = new List<Edge>{
               new Edge(B, 55),
               new Edge(C, 50)
            };

            B.neighbors = new List<Edge>{
               new Edge(A, 55),
               new Edge(D, 40),
            };

            C.neighbors = new List<Edge>{
               new Edge(A, 50),
               new Edge(E, 60),
            };

            D.neighbors = new List<Edge>{
               new Edge(B, 40),
               new Edge(E, 30),
            };

            E.neighbors = new List<Edge>
            {
                new Edge(C, 60),
                new Edge(D, 30),
            };

            return A;
        }

        public void search(Node root, Node goal)
        {
            
        }
    }
}
