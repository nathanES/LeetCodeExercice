namespace LeetCodeExercice.Exercice._1301_1400;

public class Ex1342
{
    public Ex1342()
    {
        if (NumberOfSteps(14) != 6)
            throw new Exception("ex 1 : faux");
        if (NumberOfSteps(8) != 4)
            throw new Exception("ex 2 : faux");
        if (NumberOfSteps(123) != 12)
            throw new Exception("ex 3 : faux");

    }
    public int NumberOfSteps(int num)
    {
        int rep = 0;
        while (num!=0)
        {
            rep++;
            if (num % 2 == 0)
                num /= 2;
            else
                num -= 1;    
        }

        return rep;
    }
    public int NumberOfStepsByte(int num)
    {
        int rep = 0;
        while (num!=0)
        {
            rep++;
            if ((num & 1) == 0) //nums & 1 regarde si le dernier bits de num vaut 1 ou pas (pair ou impair)
                //num & 1101 compare la valeur binaire de num et de 1101(qui est en bytes) et quand les deux champs valent 1 cela retourne 1 sinon 0
                //Ex 111 0011 & 100 0101 retournerai 100 0001
                num >>= 1; //Décaller de 1 bits un nombre vers la droite revient à le diviser par 2
            else
                num --;
        }
        return rep;
    }


}