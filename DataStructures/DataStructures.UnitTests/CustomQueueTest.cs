using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class CustomQueueTest
    {
        [TestMethod]
        public void QueueTest()
        {
            var queue = new CustomQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.AreEqual(3, queue.Count);

            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(3, queue.Dequeue());
        }
    }
}
