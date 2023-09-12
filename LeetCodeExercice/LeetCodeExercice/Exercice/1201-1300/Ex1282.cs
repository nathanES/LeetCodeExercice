namespace LeetCodeExercice.Exercice._1201_1300;

public class Ex1282
{
    public Ex1282()
    {
        // Input: groupSizes = [3,3,3,3,3,1,3]
        // Output: [[5],[0,1,2],[3,4,6]]
        int[] i1 = new[] { 3, 3, 3, 3,3, 1, 3 };
        List<List<int>> o1 = new List<List<int>>()
        {
            new List<int>(){5},
            new List<int>(){0,1,2},
            new List<int>(){3,4,6}
        };
        if (GroupThePeople(i1).Equals(o1))
            throw new Exception("Exemple 1 faux");
        
        // Input: groupSizes = [2,1,3,3,3,2]
        // Output: [[1],[0,5],[2,3,4]]
        int[] i2 = new[] { 2, 1, 3, 3, 3, 2 };
        List<List<int>> o2 = new List<List<int>>()
        {
            new List<int>() { 1 },
            new List<int>(){0,5},
            new List<int>(){2,3,4}
        };
        if (GroupThePeople(i2).Equals(o2))
            throw new Exception("Exemple 2 faux");
    }
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Dictionary<int, List<int>> dico = new Dictionary<int, List<int>>();
        for (int i = 0; i< groupSizes.Length; i++)
        {
            if (!dico.ContainsKey(groupSizes[i]))
                dico.Add(groupSizes[i],new List<int>());
            dico[groupSizes[i]].Add(i);
        }

        foreach (var itemDico in dico)
        {
            List<int> group = new List<int>();
            for (int i = 0; i < itemDico.Value.Count; i++)
            {
                group.Add(itemDico.Value[i]);
                if ((i+1) % itemDico.Key == 0 )
                {
                    result.Add(group);
                    group = new List<int>();
                }
            }
        }

        return result;
    }
}