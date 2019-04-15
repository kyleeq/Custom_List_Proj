using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringOverride
    {
        [TestMethod]
        public void OverrideToString_Test1()
        {
            // Arrange
            CustomList<int> aList = new CustomList<int>();

            string expected = "0123";
            string actual;

            // Act
            aList.AddThingy(0);
            aList.AddThingy(1);
            aList.AddThingy(2);
            aList.AddThingy(3);

            actual = aList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverrideToString_Test2()
        {
            // Arrange
            CustomList<string> aList = new CustomList<string>();

            string expected = "Hello darkness my old friend";
            string actual;

            // Act
            aList.AddThingy("Hello ");
            aList.AddThingy("darkness ");
            aList.AddThingy("my ");
            aList.AddThingy("old ");
            aList.AddThingy("friend");

            actual = aList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverrideToString_Test3()
        {
            // Arrange
            CustomList<int> aList = new CustomList<int>();

            string expected = "314159265";
            string actual;

            // Act
            aList.AddThingy(3);
            aList.AddThingy(1);
            aList.AddThingy(4);
            aList.AddThingy(1);
            aList.AddThingy(5);
            aList.AddThingy(9);
            aList.AddThingy(2);
            aList.AddThingy(6);
            aList.AddThingy(5);

            actual = aList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverrideToString_TestCount()
        {
            // Arrange
            CustomList<int> aList = new CustomList<int>();

            int expectedLength = 9;
            string newString;
            int actualLength;

            // Act
            aList.AddThingy(3);
            aList.AddThingy(1);
            aList.AddThingy(4);
            aList.AddThingy(1);
            aList.AddThingy(5);
            aList.AddThingy(9);
            aList.AddThingy(2);
            aList.AddThingy(6);
            aList.AddThingy(5);

            newString = aList.ToString();
            actualLength = newString.Length;


            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
