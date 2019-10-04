using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.Test
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void CheckIfWordInSentence_CompareWordToSentence_True()
        {
                string UserSentence = "Candied candycanes";
                string UserWordInput = "can";
                bool Actual = WordSearching.Finder(UserSentence, UserWordInput);
                bool Expected = true;

                    Assert.AreEqual(Expected, Actual);
        }
    }
}