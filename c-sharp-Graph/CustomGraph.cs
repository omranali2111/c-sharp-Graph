using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Graph
{
    internal class CustomGraph
    {
        private Dictionary<string, List<string>> graph;

        public CustomGraph() 
        {
            graph = new Dictionary<string, List<string>>();
        
        }

        public void AddVertex( string vertex )
        {
            if ( !graph.ContainsKey( vertex ) ) 
            {
                graph[ vertex ] = new List<string>();
            }
        }

        public void AddEdge(string vertex1,string vertex2)
        {
            if(graph.ContainsKey( vertex1 )&& graph.ContainsKey(vertex2 ))
            {
                graph[ vertex1 ].Add( vertex2 );
                graph[ vertex2 ].Add( vertex1 );
            }
        }
        public List<string> GetNeighbor(string vertexes)
        {
            if (graph.ContainsKey(vertexes))
            {
                return graph[ vertexes ];
            }
            return null;

        }
        public Dictionary<string, List<string>> PrintGraph()
        {
            return graph;
        }
    }
}
