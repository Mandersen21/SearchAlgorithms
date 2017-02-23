using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class DepthFirstAlgorithm
    {
        public Node BuildDFSGraph()
        {
            Node A = new Node("A", false);
            Node B = new Node("B", false);
            Node C = new Node("C", false);
            Node D = new Node("D", false);
            Node E = new Node("E", false);
            Node H = new Node("H", false);
            Node S = new Node("S", false);

            // Set edges
            A.isEdgeOf(S);
            A.isEdgeOf(B);

            B.isEdgeOf(C);

            S.isEdgeOf(E);
            S.isEdgeOf(D);

            E.isEdgeOf(H);

            return A;
        }

        public void Traverse(Node root)
        {
            Queue<Node> traverseOrder = new Queue<Node>();

            Stack<Node> S = new Stack<Node>();

            S.Push(root);

            while (S.Count > 0)
            {
                // Removes and return the object from the stack
                Node p = S.Pop();

                if (!p.isDiscovered(p))
                {
                    p.discovered = true;
                    Console.WriteLine(p + " has been discovered");

                    // Add to traverseOrder queue
                    traverseOrder.Enqueue(p);

                    foreach (Node edges in p.NodeEdges)
                    {
                        if (!S.Contains(edges))
                        {
                            S.Push(edges);
                        }
                    }
                }

            }

            while (traverseOrder.Count > 0)
            {
                Node p = traverseOrder.Dequeue();
                Console.Write(p + " ");
            }

            Console.WriteLine("\n");

        }

        public Node DepthFirstSearch(Node root, string searchNode)
        {
            Stack<Node> S = new Stack<Node>();

            S.Push(root);

            while (S.Count > 0)
            {
                // Removes and return the object from the stack
                Node p = S.Pop();

                if (!p.isDiscovered(p))
                {
                    p.discovered = true;
                    Console.WriteLine(p + " has been discovered");

                    if (p.name == searchNode)
                    {
                        return p;
                    }

                    foreach (Node edges in p.NodeEdges)
                    {
                        if (!S.Contains(edges))
                        {
                            S.Push(edges);
                        }
                    }
                }

            }

            return null;
        }
    }
}
