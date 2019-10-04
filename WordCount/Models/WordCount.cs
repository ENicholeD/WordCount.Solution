using System;

namespace WordCount.Models
{
    public class WordSearching
    {
        public string UserInput;
        public string UserWord;
        public static bool Finder(string UserInput, string UserWord)
        {
            if(UserInput.Contains(UserWord))
            {
                Console.WriteLine("this is true");
            }
        }
    }
}