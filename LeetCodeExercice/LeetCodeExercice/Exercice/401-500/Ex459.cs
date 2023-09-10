namespace LeetCodeExercice.Exercice._401_500;

public class Ex459
{
    public Ex459()
    {
        bool ex1 = RepeatedSubstringPattern("abab");
        if (!ex1)
        {
            throw new Exception("ex 1 : faux");
        }

        bool ex2 = !RepeatedSubstringPattern("aba");
        if (!ex2)
        {
            throw new Exception("ex2 : faux");
        }

        bool ex3 = RepeatedSubstringPattern("abcabcabcabc");
        if (!ex3)
        {
            throw new Exception("ex3 : faux");
        }
    }
    public bool RepeatedSubstringPattern(string s)
    {
        string doubled = s + s;
        string sub = doubled.Substring(1, doubled.Length - 2);
        return sub.Contains(s);
    }

}