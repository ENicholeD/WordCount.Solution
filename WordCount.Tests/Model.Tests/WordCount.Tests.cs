using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void CheckIfSentence_ChecksIfHasWord_True()
        {
            string userInput = "the cancan is a can do dance";
            string userWord = "can";
            bool expected = true;
            bool actual = CheckForWord.Finder(userInput, userWord);

            Assert.AreEqual(expected, actual);
        }
    }
}