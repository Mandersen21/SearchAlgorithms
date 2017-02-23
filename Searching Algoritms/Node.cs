using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class Node
    {
        public string name { get; set; }
        public bool discovered { get; set; }
        List<Node> NodeEdgesList = new List<Node>();

        public Node(string name, bool discovered)
        {
            this.name = name;
            this.discovered = discovered;
        }

        public List<Node> NodeEdges
        {
            get
            {
                return NodeEdgesList;
            }
        }

        // Add connections edges in the graph
        public void isEdgeOf(Node v)
        {
            NodeEdges.Add(v);
        }

        public bool isDiscovered(Node v)
        {
            if (v.discovered)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}

