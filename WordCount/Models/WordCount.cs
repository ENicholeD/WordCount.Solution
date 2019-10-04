using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace WordCount.Models
{
    public class CheckForWord
    {
       public static bool Finder(string UserInput, string UserWord)
       {
           bool TrueFalse = UserInput.Contains(UserWord);
       }
    }
}