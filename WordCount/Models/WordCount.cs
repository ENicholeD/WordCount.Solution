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
           }
           else
           {
               Console.WriteLine("I couldn't find anything with that word.");
           }
           return TrueFalse;
       }
    }
}