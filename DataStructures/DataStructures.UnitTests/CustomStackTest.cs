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

        [TestMethod]
        public void Pop_Test()
        {
            // ARRANGE
            var stack = new CustomStack<int>();
            stack.Push(1);

            // ACT
            var actual = stack.Pop();

            // ASSERT
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Overflow_Test()
        {
            // ARRANGE
            var stack = new CustomStack<int>();

            // ACT
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            // ASSERT
            Assert.AreEqual(10, stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EmptyPop_Test()
        {
            // ARRANGE
            var stack = new CustomStack<int>();

            // ACT
            stack.Pop();

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EmptyPeek_Test()
        {
            // ARRANGE
            var stack = new CustomStack<int>();

            // ACT
            stack.Peek();

        }

    }
}
