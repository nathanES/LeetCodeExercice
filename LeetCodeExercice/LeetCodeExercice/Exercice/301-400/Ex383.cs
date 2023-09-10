namespace LeetCodeExercice.Exercice._301_400;

public class Ex383
{
    public Ex383()
    {
        if (CanConstruct("a","b"))
            throw new Exception("ex 1 : faux");
        if (CanConstruct("aa", "ab"))
            throw new Exception("ex 2 : faux");
        if (!CanConstruct("aa","aab"))
            throw new Exception("ex 3 : faux");

    }
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> dictMagazine = new Dictionary<char, int>();
        foreach (char c in magazine)
        {
            if (dictMagazine.ContainsKey(c))
                dictMagazine[c]++;
            else
            {
                dictMagazine.Add(c,1);
            }
        }

        foreach (char c in ransomNote)
        {
            if (dictMagazine.ContainsKey(c)&& dictMagazine[c]>0)
                dictMagazine[c]--;
            else
                return false;
        }

        return true;
    }     

}