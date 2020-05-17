using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class CustomBinaryTreeTests
    {
        [TestMethod]
        public void Add_Test()
        {
            // ARRANGE
            var tree = new CustomBinaryTree<int>();

            // ACT
            //tree.Add(1);

            // ASSERT
            Assert.ThrowsException<NotImplementedException>(() => tree.Add(1));
        }
    }
}
