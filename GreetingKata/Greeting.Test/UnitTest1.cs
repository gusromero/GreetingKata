using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Greeting.Test
{
    [TestClass]
    public class GreetingUnitTest
    {
        [TestMethod]
        public void GreetSingleName()
        {
            var greetings = new Greetings();
            var result = greetings.Greet("Bob");

            Assert.AreEqual("Hello, Bob.", result);

        }
    }
}
