using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class Street
    {
        public string name { get; set; }
        public bool visited { get; set; }
        public int distanceToRoot { get; set; }

        public List<StreetNeighbor> StreetNeighborList = new List<StreetNeighbor>();

        public Street(string name, bool visited, int distanceToRoot)
        {
            this.name = name;
            this.visited = visited;
            this.distanceToRoot = distanceToRoot;
        }

        public List<StreetNeighbor> StreetsNeighbor
        {
            get
            {
                return StreetNeighborList;
            }
        }

        public void isNeighborOf(StreetNeighbor s)
        {
            StreetsNeighbor.Add(s);
        }

        public bool isVisited(Street s)
        {
            if (s.visited)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
