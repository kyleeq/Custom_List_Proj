using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class Addition_Test
    {
        [TestMethod]
        public void Add_Test1()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();

            int value = 5;
            int expected = 5;
            int actual;



            // Act
            customList.Add(value);
            actual = customList[0];
           

            // Assert
            Assert.AreEqual(expected, actual);


        }
        public void Add_Test2()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();

            int value = 4;
            int value2 = 5;
            int expected = 4;
            int actual;

            // Act
            customList.AddThingy(value2);
            customList.AddThingy(value);
            actual = customList[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_Test3()
        {
            // Arrange
            CustomList<int> fruitList = new CustomList<int>();
            int value = 0;
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;
            int value9 = 9;

            int expected = 9;
            int actual;
            
            // Act

            fruitList.AddThingy(value);
            fruitList.AddThingy(value1);
            fruitList.AddThingy(value2);
            fruitList.AddThingy(value3);
            fruitList.AddThingy(value4);
            fruitList.AddThingy(value5);
            fruitList.AddThingy(value6);
            fruitList.AddThingy(value7);
            fruitList.AddThingy(value8);
            fruitList.AddThingy(value9);


            actual = fruitList.Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_Test4()
        {
            // Arrange 
            CustomList<string> fruitList = new CustomList<string>();
            string value0 = "banana";
            string value1 = "clementine";
            string value2 = "tomato";
            string expected = "clementine";
            string actual;

            // Act
            fruitList.AddThingy(value0);
            fruitList.AddThingy(value1);
            fruitList.AddThingy(value2);
            actual = fruitList[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_Test5()
        {
            // Arrange
            CustomList<bool> dontBeBoolList = new CustomList<bool>();

            bool value = true;
            bool False = false;
            bool expected = true;
            bool actual;

            // Act
            dontBeBoolList.AddThingy(False);
            dontBeBoolList.AddThingy(value);
            actual = dontBeBoolList[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}