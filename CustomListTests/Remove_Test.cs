using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class Remove_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            customList[0] += 4; 

            int value = 4;
            int expected = 4;
            int actual;

            // Act
            customList.RemoveThingy(value);
            actual = customList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
