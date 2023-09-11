using LeetCodeExercice.Common;
using LeetCodeExercice.Exercice;
using LeetCodeExercice.Exercice._1_100;
using LeetCodeExercice.Exercice._1201_1300;

namespace LeetCodeExercice;

public class LeetCodeExercice
{
    public LeetCodeExercice()
    {
        leetcodeTest();
    }
    public void leetcodeTest()
    {
        Ex1282 t = new Ex1282();
    }
    
        #region Template

        public void Exxxx()
        {
            if (MethodName() != "A")
                throw new Exception("ex 1 : faux");
            if (MethodName() != "AB")
                throw new Exception("ex 2 : faux");
            if (MethodName() != "ZY")
                throw new Exception("ex 3 : faux");
        }

        public string MethodName()
        {
            throw new NotImplementedException("template");
        }

        #endregion
    
}

