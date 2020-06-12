using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1;

namespace HW1Tests
{
    [TestClass]
    public class EmptyTests
    {
        [TestMethod]
        public void TestEmpty()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            bool expected = true;

            //Act
            bool actual = testList.IsEmpty();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Is Empty");
        }

        [TestMethod]
        public void TestNotEmpty()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            testList.AddToTail(10);
            bool expected = false;

            //Act
            bool actual = testList.IsEmpty();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Is Not Empty");
        }
    }

    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void TestAddFirst()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            testList.AddToTail(10);
            int expected = 10;

            //Act
            int actual = testList.head.data;

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Value Added");
        }

        [TestMethod]
        public void TestAddSecond()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            testList.AddToTail(10);
            testList.AddToTail(20);
            int expected = 20;

            //Act
            int actual = testList.head.next.data = 20;

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Second Value Added");
        }

        [TestMethod]
        //Combination test of AddToTail and Length
        public void TestIncrements()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            testList.AddToTail(10);
            testList.AddToTail(20);
            testList.AddToTail(30);

            int expected = 3;

            //Act
            int actual = testList.Length();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Incremented Properly");
        }
    }

    [TestClass]
    public class LengthTests
    {
        [TestMethod]
        public void TestZeroNodes()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            int expected = 0;

            //Act
            int actual = testList.Length();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Zero Nodes Counted");
        }

        [TestMethod]
        public void TestOneNode()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            testList.AddToTail(10);
            int expected = 1;

            //Act
            int actual = testList.Length();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Length of 1");
        }

        [TestMethod]
        public void TestTwoNodes()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            testList.AddToTail(10);
            testList.AddToTail(20);
            int expected = 2;

            //Act
            int actual = testList.Length();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Length of 2");
        }
    }

    [TestClass]
    public class FindTests
    {
        [TestMethod]
        public void TestFound()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            testList.AddToTail(10);
            int expected = 0;

            //Act
            int actual = testList.Find(10);

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Found and Returned");
        }

        [TestMethod]
        public void TestNotFoundPopulated()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            testList.AddToTail(10);
            int expected = -1;

            //Act
            int actual = testList.Find(20);

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Did Not Find");
        }

        [TestMethod]
        public void TestNotFoundUnpopulated()
        {
            //Arrange
            LinkedList testList = new LinkedList();
            int expected = -1;

            //Act
            int actual = testList.Find(10);

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Did Not Find");
        }
    }
}