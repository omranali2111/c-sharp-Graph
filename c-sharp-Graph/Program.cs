using c_sharp_Graph;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomGraph graph = new CustomGraph();

        // Adding vertices
        graph.AddVertex("A");
        graph.AddVertex("B");
        graph.AddVertex("C");
        graph.AddVertex("D");

        // Adding edges
        graph.AddEdge("A", "B");
        graph.AddEdge("B", "C");
        graph.AddEdge("C", "D");
        graph.AddEdge("D", "A");

        List<string> neighbors = graph.GetNeighbor("A");
        Console.WriteLine("Neighbors of A: " + string.Join(", ", neighbors));

        // Printing the graph
        Dictionary<string, List<string>> graphStructure = graph.PrintGraph();
        foreach (var vertex in graphStructure)
        {
            Console.WriteLine("Vertex: " + vertex.Key);
            Console.WriteLine("Neighbors: " + string.Join(", ", vertex.Value));
        }

        Console.WriteLine("\nBFS Traversal:");
        graph.BFS("D");

        Console.WriteLine("\nDFS Traversal:");
        graph.BFS("D");
    }
}