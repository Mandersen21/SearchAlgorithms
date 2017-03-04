using Priority_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class DijkstraAlgorithm_second
    {
        public List<Node> buildGraph()
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

            var shortestPathToFrom = new List<Node>();
            shortestPathToFrom.Add(A);
            shortestPathToFrom.Add(C);

            return shortestPathToFrom;
        }

        public void search(Node root, Node goal)
        {
            // Set cost to 0 for root node.
            root.pathCost = 0;
            root.parent = null;

            Queue<Node> shortestPathQueue = new Queue<Node>();
            List<Node> shortestPath = new List<Node>();
            SimplePriorityQueue<Node> priorityQueue = new SimplePriorityQueue<Node>();

            priorityQueue.Enqueue(root, Convert.ToSingle(root.pathCost));
            HashSet<Node> explored = new HashSet<Node>();
            var found = false;

            do
            {
                // Get head of the queue and add it as explored
                Node current = priorityQueue.Dequeue();
                explored.Add(current);
                Console.WriteLine("*** " + current.name + " is being explored ***");

                // If goal has been found, set found to true
                if (current.name.Equals(goal.name))
                {
                    found = true;
                }

                // Search all neighbors to current
                foreach (Edge edge in current.neighbors)
                {
                    Node child = edge.node;
                    double cost = edge.cost;
                    double beforeCost = 0;

                    if (!explored.Contains(child))
                    {
                        Console.WriteLine(edge.node.name + " is the child node to: " + current.name);

                        Console.WriteLine("Before calculation: " + edge.node.pathCost);
                        beforeCost = edge.node.pathCost;

                        child.pathCost = current.pathCost + cost;

                        Console.WriteLine(edge.node.name + " pathcost is now calculated to: " + edge.node.pathCost + "\n");
                        Console.WriteLine("After calculation: " + edge.node.pathCost);
                    }

                    if (!explored.Contains(child) && !priorityQueue.Contains(child))
                    {
                        child.parent = current;
                        Console.WriteLine("----" + child.name + " has been visited via: " + child.parent.name + " ---- \n");
                        priorityQueue.Enqueue(child, Convert.ToSingle(child.pathCost));
                    }
                    else if ((priorityQueue.Contains(child)) && (child.pathCost > current.pathCost))
                    {
                        if (child.pathCost < beforeCost)
                        {
                            Console.WriteLine("Its smaller than beforeCost");
                            child.parent = current;
                            Console.WriteLine("---- Status changed: " + child.name + " has been visited via: " + child.parent.name + " ---- \n");
                        }
                        else
                        {
                            child.pathCost = beforeCost;
                            Console.WriteLine(child.name + " got it's beforeCost back: " + child.pathCost);
                        }

                        // the next two calls decrease the key of the node in the queue
                        priorityQueue.Remove(child);
                        priorityQueue.Enqueue(child, Convert.ToSingle(child.pathCost));
                    }

                }
                shortestPath.Add(current);

            } while (priorityQueue.Count != 0);

            Console.WriteLine("Search is done");
            Console.WriteLine("Printing shortest path");
            shortestPathQueue.Enqueue(goal);
            shortestPathQueue.Enqueue(goal.parent);

            var searchForNextParent = goal.parent;

            while (searchForNextParent != null)
            {
                Console.WriteLine("---");
                foreach (Node node in shortestPath)
                {
                    if (node.name == searchForNextParent.name)
                    {
                        shortestPathQueue.Enqueue(node.parent);
                        searchForNextParent = node;
                    }
                }
            }

            while(shortestPathQueue.Count != 0)
            {
                var nodeInQueue = shortestPathQueue.Dequeue();
                Console.WriteLine(nodeInQueue.name + " ");
            }

        }

        public void PrintShortestPath(Node goal)
        {






            Console.WriteLine(goal.parent);


        }
    }
}
