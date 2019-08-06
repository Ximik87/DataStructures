using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class CustomStackTests
    {
        [TestMethod]
        public void Push_Test()
        {
            // ARRANGE
            var stack = new CustomStack<int>();

            // ACT
            stack.Push(1);
            stack.Push(2);

            // ASSERT
            Assert.AreEqual(2, stack.Count);
        }

    }
}
