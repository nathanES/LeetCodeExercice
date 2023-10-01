namespace LeetCodeExercice.Exercice._501_600;

public class Ex557
{
    public Ex557()
    {
        var e1 = ReverseWords("Let's take LeetCode contest");
    }
    public string ReverseWords(string s) {
        return String.Join(" ", s.Split(' ').Select(word => new string(word.Reverse().ToArray())));

    }
}