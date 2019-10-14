using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Array
{
    public class printArrayFirst
    {

        public void GetFirstArray()
        {
            int[] arr = new int[10];

            Console.WriteLine("Print First 10 Array : ");

            Console.Write("Input the 10 first Array : ");

            for(int i = 0; i<10; i++)
            {
                Console.Write("Element {0} : ",i );
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.Write("Print the Element Array : ");

            for(int j=0; j<arr.Length; j++)
            {
                Console.Write("{0} ", arr[j]);
                
            }

        }



    }
}
