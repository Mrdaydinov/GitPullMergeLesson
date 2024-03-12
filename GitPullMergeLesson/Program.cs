using System.Security.Cryptography;

namespace GitPullMergeLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Task - 1 
            Verilmiş array-də tək ədədlərin sayını tapmaq və çap etmək.
             Məsələn: [1, 2, 3, 4, 5, 6, 7] => Tək ədədlərin sayı: 4 */


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //        count++;
            //}
            //Console.WriteLine(count);


            /* Task - 2 
            Verilmiş array-də ən kiçik və ən böyük ədədlərin cəmini tapmaq. 
            Məsələn: [3, 8, 2, 10, 5] => Cəm: 12 */


            //int[] arr = { 3, 8, 2, 10, 5 };
            //int max = arr[0];
            //int min = arr[0];


            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //}
            //for (int i = 1;i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //        min = arr[i];
            //}
            //Console.WriteLine(max + min);


            /* Task - 3
            Verilmiş array-dəki ədədlərin ən böyük və ən kiçik fərqlərini tapmaq. 
            Məsələn: [5, 8, 15, 3, 7] => Fərq: 12 */


            //int[] arr = { 5, 8, 15, 3, 7 };
            //int max = arr[0];
            //int min = arr[0];


            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //}
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //        min = arr[i];
            //}
            //Console.WriteLine(max - min);


            /*  Task - 4
            Verilmiş array-dəki ədədlərin sırasını artan sıraya salmaq. 
            Məsələn: [3, 1, 5, 4, 2] => [1, 2, 3, 4, 5] */

            //int[] arr = { 3, 1, 5, 4, 2 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int temp;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[i] < arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //foreach (int i in arr)
            //    Console.WriteLine(i);


            /* Task - 5
            Verilmiş array-dəki tək və cüt ədədlərin cəmini ayrı-ayrı tapmaq. 
            Məsələn: [1, 2, 3, 4, 5] => Tək ədədlərin cəmi: 9, Cüt ədədlərin */


            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum1 = 0;
            //int sum2 = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2==0)
            //        sum2 += arr[i];
            //    else
            //        sum1 += arr[i];
            //}
            //Console.WriteLine(sum1);
            //Console.WriteLine(sum2);
        }
    }
}
