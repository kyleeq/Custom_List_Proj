using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class Remove_Test
    {
        [TestMethod]
        public void Remove_Test1()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            // check count for 0
            int value = 4;
            int expected = 0;
            int actual;

            // Act
            customList.AddThingy(4);
            customList.RemoveThingy(value);
            actual = customList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Test2()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            

            int value = 2;
            int expected = 3;
            int actual;

            // Act
            customList.AddThingy(0);
            customList.AddThingy(1);
            customList.AddThingy(2);
            customList.AddThingy(3);
            customList.AddThingy(4);
            customList.AddThingy(5);
            customList.RemoveThingy(value);
            actual = customList[2];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Test3()
        {
            // Arrange
            CustomList<string> getYoGreensKids = new CustomList<string>();

            string value = "brocolli";
            string expected = "kale";
            string actual;

            // Act
            getYoGreensKids.AddThingy("cabbage");
            getYoGreensKids.AddThingy("lima beans");
            getYoGreensKids.AddThingy("brocolli");
            getYoGreensKids.AddThingy("kale");
            getYoGreensKids.RemoveThingy(value);
            actual = getYoGreensKids[2];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Test4()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            // count instead
            int value = 3;
            int expected = 0;
            int actual;

            // Act
            customList.AddThingy(0);
            customList.AddThingy(1);
            customList.AddThingy(2);
            customList.RemoveThingy(value);
            actual = customList[3];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Test5()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();

            int expectedCount = 2;
            int actualCount;

            // Act
            customList.AddThingy(0);
            customList.AddThingy(1);
            customList.AddThingy(2);
            customList.RemoveThingy(2);
            actualCount = customList.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
