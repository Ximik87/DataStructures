using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class CustomQueueTests
    {
        [TestMethod]
        public void QueueTest()
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
    }
}
