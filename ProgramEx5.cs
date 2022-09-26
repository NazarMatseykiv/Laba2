using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first letter: ");
            string word = Console.ReadLine().Replace(" ", "");

            Console.WriteLine("Enter second letter: ");
            string word2 = Console.ReadLine().Replace(" ", "");

            if (word == word2)
            {
            Console.WriteLine(word);
            Console.WriteLine(word2);
            }  
            else
            {
            Console.WriteLine(word2);
            Console.WriteLine(word);
            }
                
        }
    }
}
