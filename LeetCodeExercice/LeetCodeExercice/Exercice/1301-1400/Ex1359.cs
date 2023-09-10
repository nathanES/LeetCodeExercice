namespace LeetCodeExercice.Exercice._1301_1400;

public class Ex1359
{
    public Ex1359()
    {
        if (CountOrders(1) != 1)
            throw new Exception("ex 1 : faux");
        if (CountOrders(2) != 6)
            throw new Exception("ex 2 : faux");
        if (CountOrders(3) !=  90)
            throw new Exception("ex 3 : faux");

    }
    
    private const int MOD = 1000000007;
    public int CountOrders(int n)
    {
        long count = 1;
        for (int i = 2; i <= n; i++) {
            count = (count * (2 * i - 1) * i) % MOD;
        }
        return (int)count;
    }
}