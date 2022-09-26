using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n+1];
            for(int i = 0; i < n+1; i++)
            arr[i] = i;
            for(int i = 2; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if(j % i == 0)
                    {
                        arr[j] = 0;
                    }
                }
            }
            for(int i = 2; i < n; i++)
                if(arr[i] != 0)
                    Console.Write(arr[i] + " ");
        }
    }
}
