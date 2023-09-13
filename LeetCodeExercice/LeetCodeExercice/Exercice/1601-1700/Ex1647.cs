namespace LeetCodeExercice.Exercice._1601_1700;

public class Ex1647
{
    public Ex1647()
    {
        if (MinDeletions("aab") != 0)
            throw new Exception("ex 1 : faux");
        
        if (MinDeletions("aaabbbcc") != 2)
            throw new Exception("ex 2 : faux");
        
        if (MinDeletions("ceabaacb") != 2)
            throw new Exception("ex 3 : faux");
   
    }
    // public int MinDeletions(string s)
    // {
    //     int result = 0;
    //
    //     Dictionary<int, int> dicoInt = new Dictionary<int, int>();
    //     for (int i = 0; i < s.Length;)
    //     {
    //         int occ = s.Where(x => x == s[0]).Count();
    //         if (!dicoInt.ContainsKey(occ))
    //             dicoInt.Add(occ, 1);
    //         else
    //             dicoInt[occ]++;
    //         s = s.Replace(s[0]+"", "");
    //     }
    //
    //     // foreach (var dicoIntEnreg in dicoInt.OrderByDescending(x=> x.Key))
    //     // {
    //     //     if(dicoIntEnreg.Key == 0)
    //     //         break;
    //     //     while (dicoIntEnreg.Value > 1)
    //     //     {
    //     //         if (!dicoInt.ContainsKey(dicoIntEnreg.Key - 1))
    //     //             dicoInt.Add(dicoIntEnreg.Key-1,0);
    //     //         dicoInt[dicoIntEnreg.Key - 1]++;
    //     //         dicoInt[dicoIntEnreg.Key]--;
    //     //         result++;
    //     //     }
    //     // }
    //     dicoInt = dicoInt.OrderByDescending(x => x.Key).ToDictionary(pair =>)
    //     for (int i = dicoInt.Count -1; i > 0; i--)
    //         {
    //             var item = dicoInt.ElementAt(i);
    //             while (item.Value > 1)
    //             {
    //                 result++;
    //                 dicoInt[item.Key]--;
    //                 if (!dicoInt.ContainsKey(item.Key- 1))
    //                     dicoInt.Add(item.Key-1, 0);
    //                 dicoInt[item.Key - 1]++;
    //             }
    //         }
    //     
    //     
    //     return result;
    // }


    public int MinDeletions(string s)
    {
        Dictionary<char, int> cnt = new Dictionary<char, int>();
        int deletions = 0;
        HashSet<int> used_frequencies = new HashSet<int>();

        foreach (char c in s)
        {
            if (cnt.ContainsKey(c)) cnt[c]++;
            else cnt[c] = 1;
        }

        foreach (int freqReadOnly in cnt.Values)
        {
            int freq = freqReadOnly;
            while (freq > 0 && used_frequencies.Contains(freq))
            {
                freq--;
                deletions++;
            }

            used_frequencies.Add(freq);
        }

        return deletions;
    }
}