using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ZippidyDippidy_Test
    {
        [TestMethod]
        public void ZippidyDippidy_Test1_MidIndex_fromListOne()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 5;
            int actual;

            // Act
            listOne.AddThingy(1);
            listOne.AddThingy(3);
            listOne.AddThingy(5);
            listTwo.AddThingy(2);
            listTwo.AddThingy(4);
            listTwo.AddThingy(6);
            listTwo.AddThingy(8);
            listTwo.AddThingy(10);
            listTwo.AddThingy(12);

            newList = CustomList<int>.ZippidyDippidy(listOne, listTwo);
            actual = newList[4];


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZippidyDippidy_Test2_MidIndex_fromListTwo()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 4;
            int actual;

            // Act
            listOne.AddThingy(1);
            listOne.AddThingy(3);
            listOne.AddThingy(5);
            listOne.AddThingy(7);
            listOne.AddThingy(9);
            listOne.AddThingy(11);
            listTwo.AddThingy(2);
            listTwo.AddThingy(4);
            listTwo.AddThingy(6);

            newList = CustomList<int>.ZippidyDippidy(listOne, listTwo);
            actual = newList[3];


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZippidyDippidy_Test3_LastIndex_fromListTwo()
        {
            // Arrange
            // listOne will always start filling at index 0
            // listTwo will always start filling at index 1 
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 11;
            int actual;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(2);
            listOne.AddThingy(4);
            listTwo.AddThingy(1);
            listTwo.AddThingy(3);
            listTwo.AddThingy(5);
            listTwo.AddThingy(7);
            listTwo.AddThingy(9);
            listTwo.AddThingy(11);

            newList = CustomList<int>.ZippidyDippidy(listOne, listTwo);
            actual = newList[8];


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZippidyDippidy_Test4_LastIndex_fromListOne()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expected = 10;
            int actual;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(2);
            listOne.AddThingy(4);
            listOne.AddThingy(6);
            listOne.AddThingy(8);
            listOne.AddThingy(10);
            listTwo.AddThingy(1);
            listTwo.AddThingy(3);
            listTwo.AddThingy(5);

            newList = CustomList<int>.ZippidyDippidy(listOne, listTwo);
            actual = newList[8];


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZippidyDippidy_Test5_NewListCount()
        {
            // Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            int expectedCount = 7;
            int actualCount;

            // Act
            listOne.AddThingy(0);
            listOne.AddThingy(2);
            listOne.AddThingy(4);
            listOne.AddThingy(6);
            listTwo.AddThingy(1);
            listTwo.AddThingy(3);
            listTwo.AddThingy(5);

            newList = CustomList<int>.ZippidyDippidy(listOne, listTwo);
            actualCount = newList.Count;


            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
