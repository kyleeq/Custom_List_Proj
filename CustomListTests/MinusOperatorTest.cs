using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class MinusOperatorOverloadTest
    {
        [TestMethod]
        public void MinusOperator_Test()
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
            listTwo.AddThingy(4);
            listTwo.AddThingy(1);
            listTwo.AddThingy(5);

            newList = listOne - listTwo;
            actual = newList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_Test2()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 4;
            int actual;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(3);
            listOne.AddThingy(4);
            listTwo.AddThingy(3);
            listTwo.AddThingy(2);
            listTwo.AddThingy(8);

            newList = listOne - listTwo;
            actual = newList[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_Test3()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 5;
            int actual;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(3);
            listOne.AddThingy(4);
            listOne.AddThingy(5);
            listTwo.AddThingy(3);
            listTwo.AddThingy(4);
            listTwo.AddThingy(0);

            newList = listOne - listTwo;
            actual = newList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }    
}
