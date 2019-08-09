using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class CustomLinkedListTests
    {
        [TestMethod]
        public void Add_Test()
        {
            // ARRANGE
            var list = new CustomLinkedList<int>();
            
            // ACT
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // ASSERT
            Assert.AreEqual(3, list.Count);
        }
        
        [TestMethod]
        public void RemoveHead_Test()
        {
            // ARRANGE
            var list = new CustomLinkedList<int>();           
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            // ACT
            list.Remove(1);

            // ASSERT
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void RemoveMid_Test()
        {
            // ARRANGE
            var list = new CustomLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            // ACT
            list.Remove(2);

            // ASSERT
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void RemoveTail_Test()
        {
            // ARRANGE
            var list = new CustomLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            // ACT
            list.Remove(4);

            // ASSERT
            Assert.AreEqual(3, list.Count);
        }
        
        [TestMethod]
        public void Clear_Test()
        {
            // ARRANGE
            var list = new CustomLinkedList<int>();
            list.Add(1);
            list.Add(2);

            // ACT
            list.Clear();

            // ASSERT
            Assert.AreEqual(0, list.Count);
        }
    }
}
