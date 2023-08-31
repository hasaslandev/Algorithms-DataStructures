using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class BigOExercise_Calc2
    {
        public void BigOExercise_Calc1Method2(int[] input)
        {
            int a = 5;//O(1)
            int b =10;//O(1)
            int c =50;//O(1)
            for (int i = 0; i < input.Length; i++)//O(n)
            {
                int x = i + 1;//O(n)
                int y = i + 1;//O(n)
                int z = i + 1;//O(n)
            }
            for (int j = 0;j < input.Length; j++)//O(n)
            {
                int p = j * 2;//O(n)
                int q = j * 2;//O(n)
            }
            string whoAmI = "I Don't Know";//O(1)
        }
        //BIG O(4+5N) or 7N if we include this for loop
    }
}
