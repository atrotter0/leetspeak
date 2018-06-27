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
