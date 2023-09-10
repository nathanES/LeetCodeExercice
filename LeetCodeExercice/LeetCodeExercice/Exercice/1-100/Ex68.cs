namespace LeetCodeExercice.Exercice._1_100;

public class Ex68
{
    public Ex68()
    {
        string[] wordsI1 = new string[]
        {
            "This", "is", "an", "example", "of", "text", "justification."
        };
        List<string> wordsO1 = new List<string>()
        {
            "This    is    an",
            "example  of text",
            "justification.  "
        };
        if (FullJustify(wordsI1, 16) != wordsO1)
            throw new Exception("ex 1 : faux");


        string[] wordsI2 = new string[]
        {
            "What", "must", "be", "acknowledgment", "shall", "be"
        };
        List<string> wordsO2 = new List<string>()
        {
            "What   must   be",
            "acknowledgment  ",
            "shall be        "
        };
        if (FullJustify(wordsI2, 16) != wordsO2)
            throw new Exception("ex 2 : faux");


        string[] wordsI3 = new string[]
        {
            "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.",
            "Art", "is", "everything", "else", "we", "do"
        };
        List<string> wordsO3 = new List<string>()
        {
            "Science  is  what we",
            "understand      well",
            "enough to explain to",
            "a  computer.  Art is",
            "everything  else  we",
            "do                  "
        };
        if (FullJustify(wordsI3, 20) != wordsO3)
            throw new Exception("ex 3 : faux");
    }
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var res = new List<string>();
        var cur = new List<string>();
        int num_of_letters = 0;

        foreach (var word in words)
        {
            if (word.Length + cur.Count + num_of_letters > maxWidth)
            {
                for (int i = 0; i < maxWidth - num_of_letters; i++)
                {
                    cur[i % (cur.Count - 1 > 0 ? cur.Count - 1 : 1)] += " ";
                }

                res.Add(string.Join("", cur));
                cur.Clear();
                num_of_letters = 0;
            }

            cur.Add(word);
            num_of_letters += word.Length;
        }

        string lastLine = string.Join(" ", cur);
        while (lastLine.Length < maxWidth) lastLine += " ";
        res.Add(lastLine);

        return res;
    }
}