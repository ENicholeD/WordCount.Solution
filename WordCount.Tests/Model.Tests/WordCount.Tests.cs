using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.Test
{
    [TestClass]
    public class WordTest
    {
        public static string UserSentence = "The Coyote loves to eat candycane coated cottencandy";
        public static string UserWord = "Candy";
        bool ContainingWord = UserSentence.Contains(UserWord);
        {
            
        }
    }
}