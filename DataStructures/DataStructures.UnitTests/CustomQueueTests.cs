using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class CustomQueueTests
    {
        [TestMethod]
        public void Dequeue_Test()
        {
            // ARRANGE
            var queue = new CustomQueue<int>();

            // ACT
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // ASSERT
            Assert.AreEqual(3, queue.Count);

            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(3, queue.Dequeue());
        }

        [TestMethod]
        public void Enqueue_Test()
        {
            // ARRANGE
            var queue = new CustomQueue<int>();

            // ACT
            queue.Enqueue(1);
            queue.Enqueue(2);

            // ASSERT
            Assert.AreEqual(2, queue.Count);
        }

        [TestMethod]
        public void Overflow_Test()
        {
            // ARRANGE
            var queue = new CustomQueue<int>();

            // ACT
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            // ASSERT
            Assert.AreEqual(10, queue.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EmptyDequeue_Test()
        {
            // ARRANGE
            var queue = new CustomQueue<int>();

            // ACT
            queue.Dequeue();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EmptyPeek_Test()
        {
            // ARRANGE
            var queue = new CustomQueue<int>();

            // ACT
            queue.Peek();
        }

    }
}
