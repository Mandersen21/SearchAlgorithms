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
        public bool visited { get; set; } 
        public int cost { get; set; }

        public List<Edge> neighbors = new List<Edge>();

        // Implemented with name, visited
        public Node(string Name, bool Visited)
        {
            name = Name;
            visited = Visited;
        }

        // Implemented with only name & cost
        public Node(string Name, int Cost)
        {
            name = Name;
            cost = Cost;
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

