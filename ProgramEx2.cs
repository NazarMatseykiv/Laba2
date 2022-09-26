using System;
using System.Linq;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Enter n - rotate: ");
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[arr.Length];
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < n; i++)
            {
                arr2[0] = arr[arr.Length - 1];
                for (int j = 1; j < arr2.Length; j++)
                {
                    arr2[j] = arr[j - 1];
                }
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += arr2[j];
                }
                arr = arr2;
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
