using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class CustomSetTests
    {
        [TestMethod]
        public void AddTest()
        {
            // ARRANGE
            var set = new CustomSet<int>();

            // ACT
            set.Add(1);

            // ASSERT
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void AddWithDuplicateTest()
        {
            // ARRANGE
            var set = new CustomSet<int>();

            // ACT
            set.Add(1);
            set.Add(1);

            // ASSERT
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void RemoveTest()
        {
            // ARRANGE
            var set = new CustomSet<int>();
            set.Add(1);

            // ACT          
            set.Remove(1);

            // ASSERT
            Assert.AreEqual(0, set.Count);
        }

    }
}
