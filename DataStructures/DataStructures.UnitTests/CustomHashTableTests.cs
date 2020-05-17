using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class CustomHashTableTests
    {
        [TestMethod]
        public void Add_Test()
        {
            var hashtable = new CustomHashTable<int>();

            for (int i = 0; i < 125; i++)
            {
                hashtable.Add(i);
            }

            hashtable.Add(1);
        }
    }
}
