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
        public double pathCost { get; set; }
        public Node parent { get; set; }

        public List<Edge> neighbors = new List<Edge>();

        // Implemented with name, visited
        public Node(string Name)
        {
            name = Name;
        }
    }
}

