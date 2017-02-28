using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class Node
    {
        public string name;
        public bool visited { get; } 
        public int cost { get; }

        public List<Edge> neighbors = new List<Edge>();

        // Implemented with name, visited
        public Node(string Name, bool Visited)
        {
            name = Name;
            visited = Visited;
        }

        // Implemented with only name & visited
        public Node(string Name, int Cost)
        {
            name = Name;
            cost = Cost;
        }

        // Add neighbor to node
        public void isNeighborOf(Node v, int Cost)
        {
            neighbors.Add(new Edge(v, Cost));
        }

        // Check if Node has been visited
        public bool isVisited(Node v)
        {
            if (v.visited)
                return true;
            else
                return false;
        }

        public int getCost(Node v)
        {
            return cost;
        }
    }
}

