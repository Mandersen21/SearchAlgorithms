using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class GraphBuilder
    {
        public SearchProblem BuildGraph1()
        {
            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");

            // Add neighbors to all nodes
            A.neighbors = new List<Edge>{
                new Edge(B, 6),
                new Edge(D, 1)
            };

            B.neighbors = new List<Edge>{
               new Edge(A, 6),
               new Edge(C, 5),
               new Edge(D, 2),
               new Edge(E, 2),
            };

            C.neighbors = new List<Edge>{
               new Edge(B, 5),
               new Edge(E, 5),
            };

            D.neighbors = new List<Edge>{
               new Edge(A, 1),
               new Edge(B, 2),
               new Edge(E, 1),
            };

            E.neighbors = new List<Edge>
            {
                new Edge(B, 2),
                new Edge(C, 5),
                new Edge(D, 1),
            };

            return new SearchProblem(A, C);
        }

        public SearchProblem BuildGraph2()
        {
            Node A = new Node("Sibiu");
            Node B = new Node("Fagaras");
            Node C = new Node("Rimnicu Vilcea");
            Node D = new Node("Pitesti");
            Node E = new Node("Bucharest");

            // Add neighbors to all nodes
            A.neighbors = new List<Edge>{
                new Edge(B, 99),
                new Edge(C, 80)
            };

            B.neighbors = new List<Edge>{
               new Edge(A, 99),
               new Edge(E, 10)
            };

            C.neighbors = new List<Edge>{
               new Edge(A, 80),
               new Edge(D, 97),
            };

            D.neighbors = new List<Edge>{
               new Edge(C, 97),
               new Edge(E, 101),
            };

            E.neighbors = new List<Edge>
            {
                new Edge(B, 10),
                new Edge(D, 101),
            };

            return new SearchProblem(A, E);
        }
    }
}
