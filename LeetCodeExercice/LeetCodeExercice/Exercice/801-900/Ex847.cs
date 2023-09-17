namespace LeetCodeExercice.Exercice._801_900;

public class Ex847
{
    public Ex847()
    {
        // Input: graph = [[1,2,3],[0],[0],[0]]
        // Output: 4
        var ex1 = ShortestPathLength(new[] { new[] { 1, 2, 3 }, new[] { 0 }, new[] { 0 }, new[] { 0 } });
        // Input: graph = [[1],[0,2,4],[1,3,4],[2],[1,2]]
        // Output: 4
        var ex2 = ShortestPathLength(new[] { new[] { 1 }, new[] { 0,2,4 }, new[] { 1,3,4 }, new[] { 2 }, new []{1,2} });

    }
    public int ShortestPathLength(int[][] graph)
    {
        int n = graph.Length;
        int allVisited = (1 << n) - 1;
        Queue<int[]> queue = new Queue<int[]>();
        HashSet<int> visited = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            queue.Enqueue((new []{1<<i,i,0}));
            visited.Add((1 << i) * 16 + i);
        }

        while (queue.Count > 0)
        {
            int[] cur = queue.Dequeue();
            if (cur[0] == allVisited)
                return cur[2];

            foreach (int neighbor in graph[cur[1]])
            {
                int newMask = cur[0] | (1 << neighbor);
                int hashValue = newMask * 16 + neighbor;

                if (!visited.Contains(hashValue))
                {
                    visited.Add(hashValue);
                    queue.Enqueue(new []{newMask, neighbor,cur[2]+ 1});
                }
            }
        }

        return -1;
    }
}