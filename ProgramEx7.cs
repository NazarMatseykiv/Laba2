using System;
using System.Linq;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longlen = 1;
            int longstart = 0;
            int len = 1;
            int start = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    len++;
                    if (len > longlen)
                    {
                        longlen = len;
                        longstart = start;
                    }
                }
                else
                {
                    len = i;
                    start = 1;
                }
            }
            int n = longlen + longstart;
            for (int i = longstart; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
