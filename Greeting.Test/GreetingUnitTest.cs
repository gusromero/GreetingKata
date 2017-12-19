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

            result = _greetings.Greet("");

            Assert.AreEqual("Hello, my friend.", result);
        }

        [TestMethod]
        public void GreetShouting()
        {
            string result = _greetings.Greet("JERRY");

            Assert.AreEqual("HELLO JERRY!", result);

            result = _greetings.Greet("Jerry");

            Assert.AreEqual("Hello, Jerry.", result);

            result = _greetings.Greet("JeRRy");

            Assert.AreEqual("Hello, JeRRy.", result);
        }

        [TestMethod]
        public void GreetTwoNames()
        {
            string result = _greetings.Greet("Jill", "Jane");
            Assert.AreEqual("Hello, Jill and Jane.", result);
        }
    }
 }
