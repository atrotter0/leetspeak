using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.Tests
{
    [TestClass]
    public class LeetspeakTest
    {
        [TestMethod]
        public void SetGetUserInput_TestForSetGetInput_CharArray()
        {
            Leetspeak testLeetSpeak = new Leetspeak();
            testLeetSpeak.SetUserInput("Dude");
            CollectionAssert.AreEqual(new char[]{'D','u','d','e'}, testLeetSpeak.GetUserInput());
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
