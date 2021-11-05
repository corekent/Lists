using NUnit.Framework;

namespace LinkedList.Tests
{
    public class LinkedListTests
    {
        [SetUp]
        public void Setup()
        {
        }
        //arrange
        //act
        //assert
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 2}, 2)]
        [TestCase(new int[] { 1, 1, 1, 1, 1}, 5)]
        public void GetLengthTest(int[] array, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            int actual = list.GetLength();
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { }, 0, new int[] { 0 })]
        [TestCase(new int[] { 1, 2 }, 2, new int[] { 2, 1, 2})]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5, new int[] { 5, 1, 1, 1, 1, 1 })]
        public void AddFirsyTest(int[] array, int val, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.AddFirst(val);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { }, 0, new int[] { 0 })]
        [TestCase(new int[] { 1, 2 }, 2, new int[] { 2, 1, 2 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5, new int[] { 5, 1, 1, 1, 1, 1 })]
        public void AddFirsyTest(int[] array, int val, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.AddFirst(val);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}