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

        public void BFS(string vertex)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            Queue<string> queue = new Queue<string>();

            visited[vertex] = true;
            queue.Enqueue(vertex);

            while (queue.Count != 0)
            {
                vertex = queue.Dequeue();
                Console.WriteLine("next => " + vertex);

                foreach (string neighbor in graph[vertex])
                {
                    if (!visited.ContainsKey(neighbor))
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

    }
}
