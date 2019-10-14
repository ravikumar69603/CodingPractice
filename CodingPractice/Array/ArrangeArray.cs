using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Array
{
    public class ArrangeArray
    {


        public void arrangeArryFields()
        {

            int i, j,temp;
            int[] array1 = { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 };

            Console.WriteLine("Arrange the Array");


            for (i = 0; i < array1.Length; i++)
            {             
                if (array1[i] == 1)
                {
                    for (j = i; j < array1.Length; j++)
                    {

                        if (array1[j] == 0)
                        {
                            temp = array1[i];
                            array1[i] = array1[j];
                            array1[j] = temp;
                            
                            break;
                        }

                    }
                    
                }

            }

            Console.WriteLine("Print the Array Value : ");

            for(i =0; i<array1.Length; i++)
            {
                Console.Write("{0} ", array1[i]);
            }

        }


    }
}
