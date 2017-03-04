using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoritms
{
    public class SearchProblem
    {
        public Node root { get; set; }
        public Node goal { get; set; }

        public SearchProblem(Node root, Node goal)
        {
            this.root = root;
            this.goal = goal;
        }

        public Node getRoot()
        {
            return root;
        }

        public Node getGoal()
        {
            return goal;
        }
    }
}
