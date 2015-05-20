using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructure
{
    public class AdjacencyListGraph
    {
        public Dictionary<int, List<Node>> AdjacencyList;
        public int GetDegree(int nodeId)
        {
            return AdjacencyList[nodeId].Count;
        }
    }
}
