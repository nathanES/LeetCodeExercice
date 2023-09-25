namespace LeetCodeExercice.Exercice._301_400;

public class Ex389
{
    public Ex389()
    {
        var e1 = FindTheDifferenceCorrection("abcda", "abcdea");
    }

    public char FindTheDifferenceCorrection(string s, string t)
    {
        char result = (char)0;
        var l = s + t;
        foreach (char c in l) {
            result ^= c; //Xor operation c#
        }
        return result;
    }
    public char FindTheDifference(string s, string t)
    {
        if (string.IsNullOrEmpty(s))
            return t[0];
        s = String.Concat(s.OrderBy(c => c));
        t = String.Concat(t.OrderBy(c => c));
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != t[i] )
                return t[i];
        }

        return t[t.Length - 1];
    }
}