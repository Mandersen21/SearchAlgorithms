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
        public void search(Node root, Node goal)
        {
            Console.WriteLine("Starting search using dijstra algoritme");
            Console.WriteLine(" ");

            // Set cost to 0 for root node.
            root.pathCost = 0;

            SimplePriorityQueue<Node> priorityQueue = new SimplePriorityQueue<Node>();

            priorityQueue.Enqueue(root, Convert.ToSingle(root.pathCost));

            HashSet<Node> explored = new HashSet<Node>();
            var found = false;

            do
            {
                // Get head of the queue and add it as explored
                Node current = priorityQueue.Dequeue();
                explored.Add(current);
                Console.WriteLine("Node " + current.name + " is being explored");

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
                        beforeCost = edge.node.pathCost;
                        child.pathCost = current.pathCost + cost;
                    }

                    if (!explored.Contains(child) && !priorityQueue.Contains(child))
                    {
                        child.parent = current;
                        priorityQueue.Enqueue(child, Convert.ToSingle(child.pathCost));
                    }

                    else if ((priorityQueue.Contains(child)) && (child.pathCost > current.pathCost))
                    {
                        if (child.pathCost < beforeCost)
                        {
                            child.parent = current;
                        }
                        else
                        {
                            child.pathCost = beforeCost;
                        }

                        // the next two calls decrease the key of the node in the queue
                        priorityQueue.Remove(child);
                        priorityQueue.Enqueue(child, Convert.ToSingle(child.pathCost));
                    }

                }

            } while (priorityQueue.Count != 0);

            Console.WriteLine(" ");
            Console.WriteLine("Search is done");

            // Print shortest path
            printPath(goal);
        }

        public void printPath(Node target)
        {
            Console.Write("The shortest path are calculated to: ");

            List<Node> path = new List<Node>();
            for (Node node = target; node != null; node = node.parent)
            {
                path.Add(node);
            }

            path.Reverse();

            foreach (Node node in path)
            {
                Console.Write(node.name + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

    }
}



















// Succesors means children of a node.

// Set cost to 0 for root node.
//root.pathCost = 0;

//            Queue<Node> shortestPath = new Queue<Node>();
//SimplePriorityQueue<Node> priorityQueue = new SimplePriorityQueue<Node>();

//priorityQueue.Enqueue(root, Convert.ToSingle(root.pathCost));
//            HashSet<Node> explored = new HashSet<Node>();
//var found = false;

//            do
//            {   
//                // Get head of the queue and add it as explored
//                Node current = priorityQueue.Dequeue();
//explored.Add(current);
//                Console.WriteLine(current.name + " has been explored");

//                // If goal has been found, set found to true
//                if (current.name.Equals(goal.name))
//                {
//                    found = true;
//                }

//                // Search all neighbors to current
//                foreach (Edge edge in current.neighbors)
//                {
//                    Node child = edge.node;
//double cost = edge.cost;
//child.pathCost = current.pathCost + cost;

//                    if (!explored.Contains(child) && !priorityQueue.Contains(child))
//                    {
//                        //Console.WriteLine(child.name + " is not explored and is not in priority queue");
//                        child.parent = current;
//                        priorityQueue.Enqueue(child, Convert.ToSingle(child.pathCost));
//                    }
//                    else if ((priorityQueue.Contains(child)) && (child.pathCost > current.pathCost))
//                    {
//                        child.parent = current;

//                        // the next two calls decrease the key of the node in the queue
//                        priorityQueue.Remove(child);
//                        priorityQueue.Enqueue(child, Convert.ToSingle(child.pathCost));
//                    }
//                }

//            } while (priorityQueue.Count != 0);

//            Console.WriteLine("\nSearch ended, goal node ended with a pathCost of: " + goal.parent.pathCost);
//            Console.WriteLine("Shortest path are calculated to: " + goal.parent.name);