using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertArray methodu yaradılır. Method parametr olaraq int tipindən array və params olaraq int-lər qəbul edir.
            //Paramslardan gələn dəyərləri həmin arraya əlavə etsin və sonda dəyişilmiş hal köhnə arraya bərabər olsun.
            // (Array resize istifade etmirsiz ozunuz Custom yazirsiz)
            int[] numbers = { 1, 2, 3, 4 };
            InsertArray(ref numbers,5,6,7,9,10,11,12,13);

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }


        }
        static void InsertArray(ref int[] array, params int[] values)
        {
            
            int first_length = array.Length;
            int new_length = first_length + values.Length;

          
            Customs(ref array, new_length);

            
            for (int i = 0; i < values.Length; i++)
            {
                array[first_length + i] = values[i];
            }
        }

        static void Customs(ref int[] array, int new_size)
        {
           
            int[] newArray = new int[new_size];

            
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

    }
}
