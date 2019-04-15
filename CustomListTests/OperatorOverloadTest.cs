using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class OperatorOverloadTest
    {
        [TestMethod]
        public void OperatorOverload_TestAtIndex0()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 0;
            int actual;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(1);
            listOne.AddThingy(2);
            listTwo.AddThingy(3);
            listTwo.AddThingy(4);
            listTwo.AddThingy(5);

            newList = listOne + listTwo;
            actual = newList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperatorOverload_TestAtIndex3()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 3;
            int actual;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(1);
            listOne.AddThingy(2);
            listTwo.AddThingy(3);
            listTwo.AddThingy(4);
            listTwo.AddThingy(5);

            newList = listOne + listTwo;
            actual = newList[3];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperatorOverload_TestAtIndex5()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 5;
            int actual;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(1);
            listOne.AddThingy(2);
            listTwo.AddThingy(3);
            listTwo.AddThingy(4);
            listTwo.AddThingy(5);

            newList = listOne + listTwo;
            actual = newList[5];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperatorOverload_TestString()
        {
            // Arrange
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();

            CustomList<string> newList = new CustomList<string>();

            string expected = "banana ";
            string actual;

            // Act
            listOne.AddThingy("ring ");
            listTwo.AddThingy("banana ");
            listTwo.AddThingy("phone!");

            newList = listOne + listOne + listOne + listTwo;
            actual = newList[3];
            

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperatorOverload_TestCount()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expectedCount = 6;
            int actualCount;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(1);
            listOne.AddThingy(2);
            listTwo.AddThingy(3);
            listTwo.AddThingy(4);
            listTwo.AddThingy(5);

            newList = listOne + listTwo;
            actualCount = newList.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
