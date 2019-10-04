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
            bool actual = CheckForWord.WordFinder(userInput, userWord);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckHowOftenWordAppears_CheckForWordInstance_Int()
        {
            string userInput = "carnival carnies care";
            string userWord = "car";
            bool Boolean = true;
            int expected = 3;
            int actual = CheckForWord.InstancesOfWord(userInput, userWord, Boolean);

            Assert.AreEqual(expected, actual);
        }
    }
}