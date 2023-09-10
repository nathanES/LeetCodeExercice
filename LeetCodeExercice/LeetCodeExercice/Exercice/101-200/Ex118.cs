namespace LeetCodeExercice.Exercice._101_200;

public class Ex118
{
    public Ex118()
    {
        var ex1 = Generate(5);
        var ex2 = Generate(1); 
    }
    
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (numRows == 0)
            return result;
            
        result.Add(new List<int>(){1});
        for (int i = 2; i <= numRows; i++)
        {
            List<int> lastLine = result[result.Count - 1].ToList();
            List<int> line = new List<int>();
            for (int y = 0; y <= lastLine.Count; y++)
            {
                if (y==0 || y==lastLine.Count)
                {
                    line.Add(1);
                    continue;
                }            
                line.Add(lastLine[y-1]+lastLine[y]);
            }
            result.Add(line);
        }
        return result;
    }

}