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
               new Edge(E, 211)
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
                new Edge(B, 211),
                new Edge(D, 101),
            };

            return new SearchProblem(A, E);
        }

        public SearchProblem BuildGraph3()
        {
            Node n1 = new Node("Arad");
            Node n2 = new Node("Zerind");
            Node n3 = new Node("Oradea");
            Node n4 = new Node("Sibiu");
            Node n5 = new Node("Fagaras");
            Node n6 = new Node("Rimnicu Vilcea");
            Node n7 = new Node("Pitesti");
            Node n8 = new Node("Timisoara");
            Node n9 = new Node("Lugoj");
            Node n10 = new Node("Mehadia");
            Node n11 = new Node("Drobeta");
            Node n12 = new Node("Craiova");
            Node n13 = new Node("Bucharest");
            Node n14 = new Node("Giurgiu");

            //initialize the edges
            n1.neighbors = new List<Edge>{
            new Edge(n2,75),
            new Edge(n4,140),
            new Edge(n8,118)
        };

            n2.neighbors = new List<Edge>{
            new Edge(n1,75),
            new Edge(n3,71)
        };

            n3.neighbors = new List<Edge>{
            new Edge(n2,71),
            new Edge(n4,151)
        };

            n4.neighbors = new List<Edge>{
            new Edge(n1,140),
            new Edge(n5,99),
            new Edge(n3,151),
            new Edge(n6,80),
        };

            n5.neighbors = new List<Edge>{
            new Edge(n4,99),
            new Edge(n13,211)
        };

            n6.neighbors = new List<Edge>{
            new Edge(n4,80),
            new Edge(n7,97),
            new Edge(n12,146)
        };

            n7.neighbors = new List<Edge>{
            new Edge(n6,97),
            new Edge(n13,101),
            new Edge(n12,138)
        };

            n8.neighbors = new List<Edge>{
            new Edge(n1,118),
            new Edge(n9,111)
        };

            n9.neighbors = new List<Edge>{
            new Edge(n8,111),
            new Edge(n10,70)
        };

            n10.neighbors = new List<Edge>{
            new Edge(n9,70),
            new Edge(n11,75)
        };

            n11.neighbors = new List<Edge>{
            new Edge(n10,75),
            new Edge(n12,120)
        };

            n12.neighbors = new List<Edge>{
            new Edge(n11,120),
            new Edge(n6,146),
            new Edge(n7,138)
        };

            n13.neighbors = new List<Edge>{
            new Edge(n7,101),
            new Edge(n14,90),
            new Edge(n5,211)
        };

            n14.neighbors = new List<Edge>{
            new Edge(n13,90)
        };

            return new SearchProblem(n1, n13);
        }
    }
}
