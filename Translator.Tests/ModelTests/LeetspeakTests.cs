using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Translator;

namespace Translator.Tests
{
    [TestClass]
    public class LeetspeakTest
    {
        [TestMethod]
        public void SetGetUserInput_TestForSetGetInput_CharArray()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            testLeetspeak.SetUserInput("Dude");
            CollectionAssert.AreEqual(new char[]{'D','u','d','e'}, testLeetspeak.GetUserInput());
        }

        [TestMethod]
        public void SetGetModifiedPhrase_TestForSetGetModifiedPhrase_CharArray()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            testLeetspeak.SetModifiedPhrase(new List<char> { 'D', 'u', 'd', 'e' });
            CollectionAssert.AreEqual(new List<char> { 'D', 'u', 'd', 'e' }, testLeetspeak.GetModifiedPhrase());
        }

        [TestMethod]
        public void MakeDictionary_TestDictionaryIsMade_DictionaryPopulated()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            testLeetspeak.MakeDictionary();
            Assert.AreEqual('3', testLeetspeak.GetDictionaryValue('e'));
        }

        [TestMethod]
        public void SetPreviousCharacter_TestNotAtStartOfArray_ReturnsPrevChar()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            testLeetspeak.SetUserInput("Dude");
            int index = 1;
            Assert.AreEqual('D', testLeetspeak.SetPreviousCharacter(index));
        }

        [TestMethod]
        public void SetPreviousCharacter_TestAtStartOfArray_Returns0()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            testLeetspeak.SetUserInput("Dude");
            int index = 0;
            Assert.AreEqual('0', testLeetspeak.SetPreviousCharacter(index));
        }

        [TestMethod]
        public void LetterSAtStart_TestForLetterSInsideOfWord_False()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            char character = 's';
            char prevCharacter = '0';
            int index = 1;
            Assert.AreEqual(false, testLeetspeak.LetterSAtStart(character, prevCharacter, index));
        }

        [TestMethod]
        public void LetterSAtStart_TestForLetterSAtStartOfPhrase_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            char character = 's';
            char prevCharacter = ' ';
            int index = 0;
            Assert.AreEqual(true, testLeetspeak.LetterSAtStart(character, prevCharacter, index));
        }

        [TestMethod]
        public void FoundKeyInDictionary_TestForIfKeyIsFound_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            char character = 'e';
            testLeetspeak.MakeDictionary();
            Assert.AreEqual(true, testLeetspeak.FoundKeyInDictionary(character));
        }

        [TestMethod]
        public void FoundKeyInDictionary_TestForIfKeyIsNotFound_False()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            char character = 'M';
            testLeetspeak.MakeDictionary();
            Assert.AreEqual(false, testLeetspeak.FoundKeyInDictionary(character));
        }

        [TestMethod]
        public void ReplaceValues_TestValuesAreReplaced_PhraseIsConverted()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            testLeetspeak.SetUserInput("sleets");
            testLeetspeak.MakeDictionary();
            List<char> leetWord = new List<char>() { 's', 'l', '3', '3', '7', 'z' };
            CollectionAssert.AreEqual(leetWord, testLeetspeak.ReplaceValues());
        }
    }
}
