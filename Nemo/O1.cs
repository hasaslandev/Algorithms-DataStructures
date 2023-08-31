using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class O1
    {
        public void O1Method()
        {
            int[] boxes = { 0, 1, 2, 3, 4, 5 };
            void logFirstTwoBoxes(int[] boxes)
            {
                Console.WriteLine(boxes[0]);//O(1)
                Console.WriteLine(boxes[1]);//O(1)
            }
            logFirstTwoBoxes(boxes);//O(2)
            //Grafik yatay yönde olur.
            //Girdilerimizin ne kadar büyük olduğu önemli değil, bir fonksiyon üzerinde her zaman sabit
            //miktarda zaman harcayacağız.
            //Bu kod scalable
        }

    }
}
