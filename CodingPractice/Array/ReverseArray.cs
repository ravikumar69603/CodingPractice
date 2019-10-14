using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Array
{
    public class ReverseArray
    {

        public void ReverseArrayList()
        {
            int i, n;
            int[] array = new int[100];
                        
            Console.WriteLine("Input the Number of Enter the Element : ");

            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of element in the array ",n);

            for(i=0; i < n; i++)
            {
               Console.Write("Element  {0} ", i);
               array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Print the element of the Array");

            for(i=0; i<n; i++)
            {

                Console.WriteLine("Element {0} ",array[i]);
            }

            Console.WriteLine("Reverse the Array");

            for (i = n - 1; i >= 0; i--) 
            {
                Console.WriteLine("Element {0} ", array[i]);
            }


        }



    }
}
