using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            string[] a = sentence.Split(" ");
            for (int i = 0; i<a.Length; i++){
                Console.Write(a[a.Length-1-i] + " ");
            }
            
        }
    }
}
