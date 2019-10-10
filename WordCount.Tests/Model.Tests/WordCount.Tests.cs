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
        public void CheckIfSentence_ChecksIfHasWordDespiteCasing_True()
        {
            string userInput = "Destiny Destroyed her desk";
            string userWord = "des";
            bool expected = true;
            bool actual = CheckForWord.WordFinder(userInput, userWord);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckIfSentence_ChecksIfHasWordDespitePunctuation_True()
        {
            string userInput = "Ending.";
            string userWord = "end";
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
        [TestMethod]
        public void CheckHowOftenWordApears_CheckForWordInstanceDespiteCasing_Int()
        {
            string userInput = "Dan Dangles dangerously";
            string userWord = "Dan";
            bool Boolean = true;
            int expected = 3;
            int actual = CheckForWord.InstancesOfWord(userInput, userWord, Boolean);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckHowOftenWordApears_CheckForWordInstanceDespitePunctuation_Int()
        {
            string userInput = "Missy Miss.";
            string userWord = "Miss";
            bool Boolean = true;
            int expected = 2;
            int actual = CheckForWord.InstancesOfWord(userInput, userWord, Boolean);

            Assert.AreEqual(expected, actual);
        }
    }
}