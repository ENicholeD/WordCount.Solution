using System;

namespace WordCount.Models
{
    public class CheckForWord
    {
        
       public static bool WordFinder(string UserInput, string UserWord)
       {
           string lowerInput = UserInput.ToLower();
           string lowerWord = UserWord.ToLower();
           bool TrueFalse = lowerInput.Contains(lowerWord);
           Console.WriteLine(lowerInput);
           if(TrueFalse == true)
           {
               Console.WriteLine("worked!");
               InstancesOfWord(lowerInput, lowerWord, TrueFalse);
           }
           else
           {
               Console.WriteLine("I couldn't find anything with that word.");
           }
           return TrueFalse;
       }

       public static int InstancesOfWord(string UserInput, string UserWord, bool TrueFalse)
       {
           
            int num = 0;
            string lowerInput = UserInput.ToLower();
            string lowerWord = UserWord.ToLower();
            string[] SentenceSplit = lowerInput.Split(" ");
            if(TrueFalse == true)
            {
                for(int i = 0; i < SentenceSplit.Length; i ++)
                {
                    if(SentenceSplit[i].Contains(lowerWord))
                    {
                        num ++;
                    }
                }
               Console.WriteLine("there are " + num + " instances of your word in your sentence!");
            }
            
            return num;
       }
    }
}