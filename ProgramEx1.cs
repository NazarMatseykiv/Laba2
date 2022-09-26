using System;
using System.Linq;


namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first array: ");
            string[] arr = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter second array: ");
            string[] arr2 = Console.ReadLine().Split(' ');
            int min = Math.Min(arr.Length, arr2.Length);
            int left = 0;
            int right = 0;
            for(int i = 0; i < min; i++)
            {
                if(arr[i] != arr2[i])
                {
                    break;
                }
                left++;
            }
            arr = arr.Reverse().ToArray();
            arr2 = arr2.Reverse().ToArray();
            for (int i = 0; i < min; i++)
            {
                if (arr[i] != arr2[i])
                {
                    break;
                }
                right++;
            }
            Console.WriteLine(Math.Max(left, right));
        }
    }
}
