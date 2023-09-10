namespace LeetCodeExercice.Exercice._701_800;

public class Ex767
{
    public Ex767()
    {
        if (ReorganizeString("aab") != "aba")
            throw new Exception("faux");
        if (ReorganizeString("aaab") != "")
            throw new Exception("faux");

    }
    public string ReorganizeString(string s)
    {
        Dictionary<char, int> letterFrequency = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!letterFrequency.ContainsKey(c))
                letterFrequency.Add(c, 0);
            letterFrequency[c]++;
        }

        List<char> sortedChars = new List<char>(letterFrequency.Keys);
        sortedChars.Sort((a, b) => letterFrequency[b].CompareTo(letterFrequency[a]));

        if (letterFrequency[sortedChars[0]] > (s.Length + 1) / 2) return string.Empty;

        char[] res = new char[s.Length];
        int i = 0;
        foreach (char c in sortedChars)
        {
            for (int j = 0; j < letterFrequency[c]; j++)
            {
                if (i >= s.Length) i = 1;
                res[i] = c;
                i += 2;
            }
        }

        return new string(res);
    }

}