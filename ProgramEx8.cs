using System;
using System.Linq;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = 0;
            int max = 0;
            int res = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                        k++;
                }
                if(k > max)
                {
                max = k;
                    res = arr[i];
                }
            }   
            Console.WriteLine(res);
        }
    }
}
