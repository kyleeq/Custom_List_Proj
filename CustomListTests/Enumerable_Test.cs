using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class Enumerable_Test
    {
        [TestMethod]
        public void Enumerable_Test1()
        {
            // Arange
            CustomList<int> customList = new CustomList<int>();
            
            int expected = 2;
            int actual;

            // Act
            customList.AddThingy(1);
            customList.AddThingy(2);
            customList.AddThingy(3);
            customList.AddThingy(4);
            customList.AddThingy(5);
            actual = customList[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
