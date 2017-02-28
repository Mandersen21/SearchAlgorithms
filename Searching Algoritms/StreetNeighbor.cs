using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class StreetNeighbor
    {
        public Street street { get; set; }
        public int cost { get; set; }

        public StreetNeighbor(Street street, int cost)
        {
            this.street = street;
            this.cost = cost;
        }

    }
}
