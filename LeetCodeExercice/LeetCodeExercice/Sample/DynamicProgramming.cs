namespace LeetCodeExercice.Sample;

//Dynamic programming
//On peut utiliser Dynamic Programming quand les résultats que l'on cherche dépend du résultat calculé précédement.
//Exemple : trouver le chemin dans un quadrillage, série fibonacci ...
public class DynamicProgramming
{
    //Sample to calculate NbrFibonacci
    //1,1,2,3,5,...
    //La somme des deux nombres précédents apès les deux premiers 1
    public DynamicProgramming()
    {
        int n = 10;
        Console.WriteLine("Fibonacci(" + n + "): " + Fib(n));
        Console.WriteLine("Fibonacci(" + n + ") with memoization: " + FibMemo(n));
        Console.WriteLine("Fibonacci(" + n + ") with bottom-up approach: " + FibBottomUp(n));
        
    }
    //------------------------- Option 1 ------------------------------
    // A naive recursive solution
    //La moins efficaces qui calculent toutes les posibilités plusieurs fois (pas de stockage...)
    public static int Fib(int n)
    {
        if (n == 1 || n == 2)
            return 1;
        else
            return Fib(n - 1) + Fib(n - 2);
    }

    //------------------------- Option 2 ------------------------------
    // A memoized solution
    // Utilisation de la récursion et d'un "mémo". (attention quand il y a trop de
    // reccursivité en python le compilateur plante, je ne sais pas si c'est pareil en c#)
    public static int FibMemo(int n)
    {
        int?[] memo = new int?[n + 1]; // Va stocker les valeurs
                                       // La donnée qui se trouve à l'indice 0 du tableau ne sera jamais alimenté.
                                       // On commence à l'indice 1 donc le tableau doit faire une taille de plus.
        return FibMemoHelper(n, memo);
    }

    private static int FibMemoHelper(int n, int?[] memo)
    {
        if (memo[n] != null)
            return memo[n].Value; //On a déjà calculé la valeur
        
        if (n == 1 || n == 2)
            memo[n] = 1; //Les cas les plus favorables (les deux premiers chiffres de la série vos 1)
        else
            memo[n] = FibMemoHelper(n - 1, memo) + FibMemoHelper(n - 2, memo);  // Appel récurssif
                                                                                    // On va chercher dans le mémo si on n'a pas calculé la valeur précédente
        return memo[n].Value;
    }

    //------------------------- Option 3 ------------------------------
    // A bottom-up solution
    public static int FibBottomUp(int n)
    {
        if (n == 1 || n == 2) // Cas favorable
            return 1;
        
        int[] bottomUp = new int[n + 1]; //alimentation du tableau mémo
        bottomUp[1] = 1;
        bottomUp[2] = 1; 
        for (int i = 3; i <= n; i++)
        {
            bottomUp[i] = bottomUp[i - 1] + bottomUp[i - 2]; //recherche dans le tableau mémo pour calculer le résultat suivant
        }
        return bottomUp[n]; //retour du résultat
    }


}