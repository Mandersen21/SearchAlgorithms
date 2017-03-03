using Priority_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class DijkstraAlgorithm
    {
        public List<Node> buildGraph()
        {
            Node A = new Node("Sibiu", false);
            Node B = new Node("Fagaras", false);
            Node C = new Node("Rimnicu Vilcea", false);
            Node D = new Node("Pitesti", false);
            Node E = new Node("Bucharest", false);

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

            var shortestPathToFrom = new List<Node>();
            shortestPathToFrom.Add(A);
            shortestPathToFrom.Add(E);

            return shortestPathToFrom;
        }

        public void search(Node root, Node goal)
        {
            // Set cost to 0 for root node.
            root.pathCost = 0;

            Queue<Node> shortestPath = new Queue<Node>();
            SimplePriorityQueue<Node> priorityQueue = new SimplePriorityQueue<Node>();

            priorityQueue.Enqueue(root, Convert.ToSingle(root.pathCost));
            HashSet<Node> explored = new HashSet<Node>();
            var found = false;

            do
            {   
                // Get head of the queue and add it as explored
                Node current = priorityQueue.Dequeue();
                explored.Add(current);
                Console.WriteLine(current.name + " has been explored");

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
                    child.pathCost = current.pathCost + cost;

                    if (!explored.Contains(edge.node)) {
                        Console.WriteLine("pathCost " + current.name + " are: " + current.pathCost + "\n");
                    }
                    
                    if (!explored.Contains(child) && !priorityQueue.Contains(child))
                    {
                        //Console.WriteLine(child.name + " is not explored and is not in priority queue");
                        child.parent = current;
                        priorityQueue.Enqueue(child, Convert.ToSingle(child.pathCost));

                        //Console.WriteLine(child);
                    }
                    else if ((priorityQueue.Contains(child)) && (child.pathCost > current.pathCost))
                    {
                        child.parent = current;

                        // the next two calls decrease the key of the node in the queue
                        priorityQueue.Remove(child);
                        priorityQueue.Enqueue(child, Convert.ToSingle(child.pathCost));
                    }
                }

            } while (priorityQueue.Count != 0);

            Console.WriteLine("\nSearch ended, goal node ended with a pathCost of: " + goal.pathCost);
        }
    }
}

// Succesors means children of a node.