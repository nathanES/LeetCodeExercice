namespace LeetCodeExercice.Exercice._401_500;

public class Ex412
{
    public Ex412()
    {
        if (FizzBuzz(3).Equals(new List<string>(){"1","2","Fizz"}))
            throw new Exception("ex 1 : faux");
        if (FizzBuzz(5).Equals(new List<string>(){"1","2","Fizz","4","Buzz"}))
            throw new Exception("ex 2 : faux");
        if (FizzBuzz(15).Equals(new List<string>(){"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"}))
            throw new Exception("ex 3 : faux");

    }
    public IList<string> FizzBuzz(int n)
    {
        List<string> rep = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            bool canBeDividedBy3 = i % 3 == 0;
            bool canBeDividedBy5 = i % 5 == 0;
            string currString = String.Empty;
            if (canBeDividedBy3)
                currString+="Fizz";
            if(canBeDividedBy5)
                currString+="Buzz";
            if (currString == string.Empty)
                currString = i.ToString();
            rep.Add(currString);
        }
        return rep;
    }


}