using System;

namespace WordCount.Models
{
    public class CheckForWord
    {
       public static bool WordFinder(string UserInput, string UserWord)
       {
           bool TrueFalse = UserInput.Contains(UserWord);
           if(TrueFalse == true)
           {
               Console.WriteLine("worked!");
               InstancesOfWord(UserInput, UserWord, TrueFalse);
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
            string[] SentenceSplit = UserInput.Split(" ");
            if(TrueFalse == true)
            {
                for(int i = 0; i < SentenceSplit.Length; i ++)
                {
                    if(SentenceSplit[i].Contains(UserWord))
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