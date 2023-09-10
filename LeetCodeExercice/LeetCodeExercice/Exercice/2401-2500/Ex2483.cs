namespace LeetCodeExercice.Exercice._2401_2500;

public class Ex2483
{
    public Ex2483()
    {
        if (BestClosingTime("YYNY") != 2)
            throw new Exception("ex 1 : faux");
        if (BestClosingTime("NNNNN") != 0)
            throw new Exception("ex 2 : faux");
        if (BestClosingTime("YYYY") != 4)
            throw new Exception("ex 3 : faux");
        if (BestClosingTime("NNYYYNNNNNNNNYYN") != 5)
            throw new Exception("ex 3 : faux");

    }
    public int BestClosingTime(string customers)
    {
        customers = customers.TrimEnd('N');
        int besthour = -1, max_score = 0, score = 0;

        for (int i = 0; i < customers.Length; i++)
        {
            score = customers[i] == 'Y' ? score + 1 : score - 1;
            if (score > max_score)
            {
                max_score = score;
                besthour = i;
            }
        }

        return besthour + 1;
    }

}