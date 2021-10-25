using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_21._10._2021_for_Monday
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] arr1 = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
           int [] arr2 = new int [10];
            int j = 0;

            for (int i = 0; i < arr2.Length; i++)
                {
                if (arr1 == arr2)
                {
                    j = 0;
                }
                int n = arr1[j];
                arr2[i] = n;
                j++;

                Console.WriteLine($"Array item value: {arr2[i]}");
                Console.ReadLine();
            }

        }
    }
}
