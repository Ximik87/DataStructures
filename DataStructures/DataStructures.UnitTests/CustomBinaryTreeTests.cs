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
            tree.Add(1);

            // ASSERT
            Assert.AreEqual(1, tree.Root.Value);
            Assert.IsNull(tree.Root.Left);
            Assert.IsNull(tree.Root.Right);
        }

        [TestMethod]
        public void AddMulti_Test()
        {
            // ARRANGE
            var tree = new CustomBinaryTree<int>();

            // ACT
            tree.Add(3);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);

            // ASSERT
            Assert.AreEqual(3, tree.Root.Value);
            Assert.AreEqual(2, tree.Root.Left.Value);
            Assert.AreEqual(4, tree.Root.Right.Value);
            Assert.AreEqual(5, tree.Root.Right.Right.Value);
        }

        [TestMethod]
        public void Find_Test()
        {
            // ARRANGE
            var tree = new CustomBinaryTree<int>();

            // ACT
            tree.Add(3);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);

            // ASSERT 
            Assert.IsTrue(tree.Find(3));
            Assert.IsTrue(tree.Find(2));
            Assert.IsTrue(tree.Find(4));
            Assert.IsTrue(tree.Find(5));
        }

        [TestMethod]
        public void FindNotExist_Test()
        {
            // ARRANGE
            var tree = new CustomBinaryTree<int>();

            // ACT
            tree.Add(3);

            // ASSERT 
            Assert.IsFalse(tree.Find(2));
        }
    }
}
