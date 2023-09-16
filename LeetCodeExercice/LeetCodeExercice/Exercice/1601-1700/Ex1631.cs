namespace LeetCodeExercice.Exercice._1601_1700;

public class Ex1631
{
    public Ex1631()
    {
        var ex1 = MinimumEffortPath(new[] { new[] { 1, 2, 2 }, new[] { 3, 8, 2 }, new[] { 5, 3, 5 } });
        var ex2 = MinimumEffortPath(new[] { new[] { 1, 2, 3 }, new[] { 3, 8, 4 }, new[] { 5, 3, 5 } });
        var ex3 = MinimumEffortPath(new[] { new[] { 1, 2, 1,1,1 }, new[] { 1,2,1,2,1}, new[] { 1,2,1,2,1 }, new[] { 1,2,1,2,1 }  });
    }
    //Dijkstra algo
    public int MinimumEffortPath(int[][] heights) 
    {
        int rows = heights.Length, cols = heights[0].Length;
        int[,] dist = new int[rows, cols];
        var minHeap = new SortedSet<(int effort, int x, int y)>();
        minHeap.Add((0, 0, 0));
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                dist[i, j] = int.MaxValue;
            }
        }
        dist[0, 0] = 0;
        
        int[][] directions = new int[][] { new int[]{ 0, 1 }, new int[]{ 0, -1 }, new int[]{ 1, 0 }, new int[]{ -1, 0 }};
        
        while (minHeap.Count > 0) {
            var (effort, x, y) = minHeap.Min;
            minHeap.Remove(minHeap.Min);
            
            if (effort > dist[x, y]) continue;
            
            if (x == rows - 1 && y == cols - 1) return effort;
            
            foreach (var dir in directions) {
                int nx = x + dir[0], ny = y + dir[1];
                if (nx >= 0 && nx < rows && ny >= 0 && ny < cols) {
                    int new_effort = Math.Max(effort, Math.Abs(heights[x][y] - heights[nx][ny]));
                    if (new_effort < dist[nx, ny]) {
                        dist[nx, ny] = new_effort;
                        minHeap.Add((new_effort, nx, ny));
                    }
                }
            }
        }
        return -1;
    }
}