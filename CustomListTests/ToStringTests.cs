using System;
using CustomList;

namespace CustomListTests
{
	public class ToStringTests
	{
        [TestMethod]
        public void ToString_IntList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 4;
            int value2 = 8;
            int value3 = 12;
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            expected = "4812";
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_DoubleList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<double> myList = new CustomList<double>();
            double value1 = 4.5;
            double value2 = 8.5;
            double value3 = 12.5;
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            expected = "4.58.512.5";
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_BoolList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<bool> myList = new CustomList<bool>();
            bool value1 = true;
            bool value2 = false;
            bool value3 = true;
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            expected = "TrueFalseTrue";
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_StringList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value1 = "I ";
            string value2 = "play ";
            string value3 = "the";
            string value4 = "drums";
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            expected = "I play the drums";
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

