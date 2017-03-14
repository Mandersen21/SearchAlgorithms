//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Searching_Algoritms
//{
//    public void Traverse(Node root)
//    {
//        Queue<Node> traverseOrder = new Queue<Node>();

//        Stack<Node> S = new Stack<Node>();

//        S.Push(root);

//        while (S.Count > 0)
//        {
//            // Removes and return the object from the stack
//            Node p = S.Pop();

//            if (!p.isDiscovered(p))
//            {
//                p.discovered = true;
//                Console.WriteLine(p + " has been discovered");

//                // Add to traverseOrder queue
//                traverseOrder.Enqueue(p);

//                foreach (Node edges in p.NodeEdges)
//                {
//                    if (!S.Contains(edges))
//                    {
//                        S.Push(edges);
//                    }
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

//    public Node DepthFirstSearch(Node root, string searchNode)
//    {
//        Stack<Node> S = new Stack<Node>();

//        S.Push(root);

//        while (S.Count > 0)
//        {
//            // Removes and return the object from the stack
//            Node p = S.Pop();

//            if (!p.isDiscovered(p))
//            {
//                p. = true;
//                Console.WriteLine(p + " has been discovered");

//                if (p.name == searchNode)
//                {
//                    return p;
//                }

//                foreach (Edge edges in p.neighbors)
//                {
//                    if (!S.Contains(edges))
//                    {
//                        S.Push(edges);
//                    }
//                }
//            }

//        }

//        return null;
//    }
//}

