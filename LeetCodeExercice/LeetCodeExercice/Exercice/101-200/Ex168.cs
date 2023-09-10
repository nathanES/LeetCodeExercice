namespace LeetCodeExercice.Exercice._101_200;

public class Ex168
{
    public Ex168()
    {
        if (ConvertToTitle(1) != "A")
            throw new Exception("faux");
        if (ConvertToTitle(28) != "AB")
            throw new Exception("faux");
        if (ConvertToTitle(701) != "ZY")
            throw new Exception("faux");

    }
    public string ConvertToTitle(int columnNumber, string chaine = "")
    {
        if (columnNumber <= 0) return chaine;
        int colLettre = columnNumber % 26;
        chaine = ConvertNumToLettre(colLettre) + chaine;
        if (colLettre == 0)
            columnNumber--;
        return ConvertToTitle(columnNumber / 26, chaine);
    }

    public char ConvertNumToLettre(int num) => "ZABCDEFGHIJKLMNOPQRSTUVWXY"[num];

}