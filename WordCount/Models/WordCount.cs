using System;

namespace WordCount.Models
{
    public class WordSearching
    {
        public string UserInput;
        public string UserWord;
        public static bool FindWord(string UserInput, string UserWord)
        {
            UserInput.Split("can");

            if(UserInput.Contains(UserWord))
            {
                Console.WriteLine(UserInput);
                
            }
            
        }
    }
}