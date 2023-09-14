using System.Collections.ObjectModel;

namespace LeetCodeExercice.Exercice._301_400;

public class Ex332
{
    public Ex332()
    {

        FindItinerary(new List<IList<string>>()
        {
            new List<string>() { "MUC", "LHR" }, new List<string> { "JFK", "MUC" }, new List<string> { "SFO", "SJC" },
            new List<string> { "LHR", "SFO" }
        });

    }
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        var graph = new Dictionary<string, List<string>>();
        
        foreach (var ticket in tickets) {
            if (!graph.ContainsKey(ticket[0])) {
                graph[ticket[0]] = new List<string>();
            }
            graph[ticket[0]].Add(ticket[1]);
        }
        
        foreach (var destinations in graph.Values) {
            destinations.Sort((a, b) => b.CompareTo(a));
        }
        
        var itinerary = new List<string>();
        
        void DFS(string airport) {
            while (graph.ContainsKey(airport) && graph[airport].Count > 0) {
                var next = graph[airport][^1];
                graph[airport].RemoveAt(graph[airport].Count - 1);
                DFS(next);
            }
            itinerary.Add(airport);
        }
        
        DFS("JFK");
        itinerary.Reverse();
        
        return itinerary;
    }

}