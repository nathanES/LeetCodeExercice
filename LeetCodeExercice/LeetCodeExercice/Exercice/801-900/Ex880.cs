namespace LeetCodeExercice.Exercice._801_900;

public class Ex880
{
    public Ex880()
    {
        var e1 = DecodeAtIndex(s: "leet2code3", k: 10);
        var e33 = DecodeAtIndex(s: "y959q969u3hb22odq595", k: 222280369);
        var ex = DecodeAtIndex(s: "leet2code3", k: 10);
        
    }
    public string DecodeAtIndex(string s, int k) {
        long length = 0;
        int i = 0;
        
        //On calcule la taille de la chaine jusqu"à ce que que cela dépasse k (la valeur recherché)
        while (length < k) {
            if (char.IsDigit(s[i])) {
                length *= s[i] - '0';
            } else {
                length++;
            }
            i++;
        }
        
        for (int j = i - 1; j >= 0; j--) {
            if (char.IsDigit(s[j])) {
                length /= s[j] - '0';
                k %= (int)length;
            } else {
                if (k == 0 || k == length) {
                    return s[j].ToString();
                }
                length--;
            }
        }

        return "";
    }
    
    
}