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
        public void SetGetNewPhrase_TestForSetGetNewPhrase_CharArray()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            testLeetspeak.SetNewPhrase(new List<char> { 'D', 'u', 'd', 'e' });
            CollectionAssert.AreEqual(new List<char> { 'D', 'u', 'd', 'e' }, testLeetspeak.GetNewPhrase());
        }

        [TestMethod]
        public void MakeDictionary_TestDictionaryIsMade_DictionaryPopulated()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            testLeetspeak.MakeDictionary();
            Assert.AreEqual('3', testLeetspeak.GetDictionaryValue('e'));
        }


        [TestMethod]
        public void IsLetterE_TestForE_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual(true, testLeetspeak.IsLetterE('e'));
        }

        [TestMethod]
        public void IsLetterI_TestForI_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual(true, testLeetspeak.IsLetterI('I'));
        }

        [TestMethod]
        public void IsLetterO_TestForO_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual(true, testLeetspeak.IsLetterO('o'));
        }

        [TestMethod]
        public void IsLetterT_TestForT_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual(true, testLeetspeak.IsLetterT('t'));
        }

        [TestMethod]
        public void IsLetterS_TestForS_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual(true, testLeetspeak.IsLetterS('s'));
        }
    }
}
