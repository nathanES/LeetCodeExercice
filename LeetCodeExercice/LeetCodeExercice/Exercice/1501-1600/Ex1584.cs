namespace LeetCodeExercice.Exercice._1501_1600;

public class Ex1584
{
    public Ex1584()
    {
        // Input: points = [[0,0],[2,2],[3,10],[5,2],[7,0]]
        // Output: 20
        int[][] i1 = new int[][]
        {
            new int[]{0,0},
            new int[]{2,2},
            new int[]{3,10},
            new int[]{5,2},
            new int[]{7,0}
        };
        if (MinCostConnectPoints(i1)!= 20)
            throw new Exception("Exemple 1 faux");
        
        // Input: points = [[3,12],[-2,5],[-4,1]]
        // Output: 18
        int[][] i2 = new int[][]
        {
            new int[]{3,12},
            new int[]{-2,5},
            new int[]{-4,1}
        };
        if (MinCostConnectPoints(i2)!=18)
            throw new Exception("Exemple 2 faux");
    }
    public static int ManhattanDistance(int[] p1, int[] p2) {
        return Math.Abs(p1[0] - p2[0]) + Math.Abs(p1[1] - p2[1]);
    }
//Utilisation de prisme algorithme
    public int MinCostConnectPoints(int[][] points) {
        int n = points.Length;
        bool[] visited = new bool[n];
        Dictionary<int, int> heapDict = new Dictionary<int, int>() { {0, 0} };
        var minHeap = new SortedSet<(int w, int u)>() { (0, 0) };

        int mstWeight = 0;

        while (minHeap.Count > 0) {
            var (w, u) = minHeap.Min;
            minHeap.Remove(minHeap.Min);
            
            if (visited[u] || heapDict[u] < w) continue;

            visited[u] = true;
            mstWeight += w;

            for (int v = 0; v < n; v++) {
                if (!visited[v]) {
                    int newDistance = ManhattanDistance(points[u], points[v]);
                    if (newDistance < heapDict.GetValueOrDefault(v, int.MaxValue)) {
                        heapDict[v] = newDistance;
                        minHeap.Add((newDistance, v));
                    }
                }
            }
        }

        return mstWeight;
    }
    //Utilisation de krushkall algorithm
        public int MinCostConnectPointsKrushkal(int[][] points)
    {
        // Define a helper function 'Find' to find the representative (root) of a set using path compression.
        int Find(int[] parent, int x)
        {
            if (parent[x] == x)
                return x;
            parent[x] = Find(parent, parent[x]); // Path compression: Set the parent to the root.
            return parent[x];
        }

        // Define a helper function 'Union' to unite two sets by setting one's root as the parent of the other's root.
        void Union(int[] parent, int x, int y)
        {
            parent[Find(parent, x)] = Find(parent, y); // Set root of 'x' as parent of root of 'y'.
        }

        // Get the number of points in the input.
        int n = points.Length;

        // Create a list of edges 'edges' to store the edges between points along with their Manhattan distances.
        List<Tuple<int, int, int>> edges = new List<Tuple<int, int, int>>();

        // This loop comprehensively computes the distances between all pairs of points and stores them in 'edges'.
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int cost = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                edges.Add(Tuple.Create(cost, i, j));
            }
        }

        // Sort the edges by their distances in ascending order.
        edges.Sort((a, b) => a.Item1.CompareTo(b.Item1));

        // Create an array 'parent' initialized such that each point is its own parent (initially isolated).
        int[] parent = new int[n];
        for (int i = 0; i < n; i++)
        {
            parent[i] = i;
        }

        // Initialize 'min_cost' to track the total minimum cost, and 'num_edges' to track the number of edges added to the MST.
        int min_cost = 0;
        int num_edges = 0;

        // Iterate through the sorted edges.
        foreach (var edge in edges)
        {
            int cost = edge.Item1;
            int u = edge.Item2;
            int v = edge.Item3;

            // Check if adding this edge (connecting points 'u' and 'v') doesn't create a cycle in the minimum spanning tree.
            if (Find(parent, u) != Find(parent, v))
            {
                // If it doesn't create a cycle, unite the sets containing 'u' and 'v', and update 'min_cost'.
                Union(parent, u, v);
                min_cost += cost;
                num_edges++;

                // If we have added 'n - 1' edges (forming a spanning tree), exit the loop.
                if (num_edges == n - 1)
                    break;
            }
        }

        // Return the minimum cost to connect all points (the minimum spanning tree cost).
        return min_cost;
    }
}