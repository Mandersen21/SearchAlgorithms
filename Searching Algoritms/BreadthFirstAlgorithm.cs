using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    //public class BreadthFirstAlgorithm
    //{
    //    public Node BuildBFSGraph()
    //    {
    //        Node A = new Node("A", false);
    //        Node B = new Node("B", false);
    //        Node C = new Node("C", false);
    //        Node D = new Node("D", false);
    //        Node E = new Node("E", false);
    //        Node F = new Node("F", false);

    //        // Set edges
    //        //A.isEdgeOf(B);
    //        //A.isEdgeOf(D);
    //        //B.isEdgeOf(A);
    //        //B.isEdgeOf(C);
    //        //B.isEdgeOf(E);
    //        //C.isEdgeOf(B);
    //        //C.isEdgeOf(F);
    //        //D.isEdgeOf(A);
    //        //D.isEdgeOf(E);
    //        //F.isEdgeOf(C);

    //        return A;
    //    }

    //    public void Traverse(Node root)
    //    {
    //        Queue<Node> traverseOrder = new Queue<Node>();

    //        Queue<Node> Q = new Queue<Node>();
    //        HashSet<Node> S = new HashSet<Node>();

    //        // Add root node to queue
    //        Q.Enqueue(root);
    //        S.Add(root);

    //        while (Q.Count > 0)
    //        {
    //            Node p = Q.Dequeue();
    //            Console.WriteLine("Node is being looked at: " + p);

    //            // Add node to the end of traverseOrder queue.
    //            traverseOrder.Enqueue(p);

    //            foreach (Node edges in p.NodeEdges)
    //            {
    //                if (!S.Contains(edges))
    //                {
    //                    Q.Enqueue(edges);
    //                    S.Add(edges);
    //                }
    //            }
    //        }

    //        while (traverseOrder.Count > 0)
    //        {
    //            Node p = traverseOrder.Dequeue();
    //            Console.Write(p + " ");
    //        }

    //        Console.WriteLine("\n");
    //    }

    //    public Node BreadthFirstSearch(Node root, string searchNode)
    //    {
    //        Queue<Node> Q = new Queue<Node>();
    //        HashSet<Node> S = new HashSet<Node>();

    //        // Add node to end of queue
    //        Q.Enqueue(root);

    //        // Add node to HashSet
    //        S.Add(root);

    //        while (Q.Count > 0)
    //        {
    //            Node p = Q.Dequeue();
    //            Console.WriteLine("Node to be checked: " + p);

    //            // Check if p is the one we are searching for
    //            if (p.name == searchNode)
    //            {
    //                return p;
    //            }

    //            foreach (Node edge in p.NodeEdges)
    //            {
    //                if (!S.Contains(edge))
    //                {
    //                    S.Add(edge);
    //                    Q.Enqueue(edge);
    //                }
    //            }

    //        }
    //        return null;
    //    }
    //}
}
