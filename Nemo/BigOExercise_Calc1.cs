using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class BigOExercise_Calc1
    {
        public int BigOExercise_Calc1Method(int[] input)
        {
            int a = 10;//O(1)
            a = 50 + 3;//O(1)

            for (int i = 0; i < input.Length; i++)//O(n)
            {
                anotHerFunction();// O(n)
                bool stranger = true;// O(n)
                a++;// O(n)
            }
            return a;// O(1)
        }
        //BIG O(3+4n)

        private void anotHerFunction()
        {
            throw new NotImplementedException();
        }

    }
}
