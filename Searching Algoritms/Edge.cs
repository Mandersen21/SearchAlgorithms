using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class Edge
    {
        public Node node { get; set; }
        public int cost { get; set; }

        public Edge(Node v, int Cost)
        {
            node = v;
            cost = Cost;
        }
    }
}
