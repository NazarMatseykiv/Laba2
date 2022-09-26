using System;
using System.Linq;
namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] max = new int[k * 2];
            int[] min = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                max[i] = arr[k - i - 1];
                max[max.Length - i - 1] = arr[arr.Length - k + i];
                min[i * 2] = arr[i * 2 + k];
                min[i * 2 + 1] = arr[i * 2 + k + 1];
            }
            int[] res = new int[k * 2];
            for (int j = 0; j < res.Length; j++)
            {
                res[j] = max[j] + min[j];
            }
            Console.WriteLine(string.Join(" ", res));
        }
    }
}
