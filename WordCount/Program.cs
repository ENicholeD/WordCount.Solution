using System;
using WordCount.Models;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Write a sentence");
            string UserInput = Console.ReadLine();
            Console.WriteLine("enter a word");
            string UserWord = Console.ReadLine();
            CheckForWord.WordFinder(UserInput, UserWord);
        }
        
    }
