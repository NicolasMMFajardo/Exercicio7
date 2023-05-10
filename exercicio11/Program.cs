using System;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [10] {0,1,2,3,4,5,6,7,8,9};

            printReverse(arr);

            void printReverse(int[] arr){
                for(int i = arr.Length-1; i >= 0; i--){
                    Console.WriteLine(arr[i]);    
                }
            }
        }
    }
}