using System;
using System.Linq;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = 0;
            for(int i = 0; i <arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]==n)
                    {
                        k++;
                    } 
                }
            }    
            Console.WriteLine(k);
        }
    }
}
