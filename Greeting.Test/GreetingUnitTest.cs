using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Greeting.Test
{
    [TestClass]
    public class GreetingUnitTest
    {
        private Greetings _greetings;

        [TestInitialize]
        public void InitTest()
        {
            _greetings = new Greetings();
        }
        [TestMethod]
        public void GreetSingleName()
        {
            string result = _greetings.Greet("Bob");

            Assert.AreEqual("Hello, Bob.", result);
        }

        [TestMethod]
        public void GreetNoName()
        {
            string result = _greetings.Greet(null);

            Assert.AreEqual("Hello, my friend.", result);
        }

        [TestMethod]
        public void GreetShouting()
        {
            string result = _greetings.Greet("JERRY");

            Assert.AreEqual("HELLO JERRY!", result);
        }
    }
}
