using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortingAnimation
{

    public class BubbleSort
    {
        public static void Sort(int[] array, ref int j)
        {
            
            int temp;
            for (int i=0; i < array.Length - 1; i++)
            {
                for (; j < array.Length - i - 1;)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                    break;
                }
               
            }


           
            if (j == array.Length)
            {
                
                j = 0;
            }
        }


    }
}
