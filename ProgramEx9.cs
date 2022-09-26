using System;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array: ");
            char[] arr = new char[26];
            char k = 'a';
            for (int i = 0; i < arr.Length; i++, k++)
            {
                arr[i] = k;
            }
            string letter = Console.ReadLine();
            for(int i = 0; i < letter.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(letter[i] == arr[j])
                    {
                        Console.WriteLine(letter[i] + " -> " + j);
                    }
                }    
            }
        }
    }
}
