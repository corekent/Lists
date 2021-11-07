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
        public void AddFirstTest(int[] array, int val, int[] expected)
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
        [TestCase(new int[] { 1, 2 }, 2, new int[] { 1, 2, 2 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5, new int[] { 1, 1, 1, 1, 1, 5 })]
        public void AddLastTest(int[] array, int val, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.AddLast(val);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { -2, -1, 0}, new int[] { -2, -1, 0, 1, 2 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 2, 2 }, new int[] { 2, 2, 1, 1, 1, 1, 1 })]
        public void AddFirstTest(int[] array, int[] val, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            LinkedList valList = new LinkedList(val);
            //act 
            list.AddFirst(valList);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 4, 5, 6 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 2, 2 }, new int[] { 1, 1, 1, 1, 1, 2, 2 })]
        public void AddLastTest(int[] array, int[] val, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            LinkedList valList = new LinkedList(val);
            //act 
            list.AddLast(valList);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, 0, 0, new int[] { 0 })]
        [TestCase(new int[] { 1, 3 }, 2, 1, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5, 2, new int[] { 1, 1, 5, 1, 1, 1 })]
        public void AddAtTest(int[] array, int val, int idx, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.AddAt(idx, val);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, 0, new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, 2, new int[] { 4, 5, 6 }, new int[] { 1, 2, 4, 5, 6 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 3, new int[] { 2, 2 }, new int[] { 1, 1, 1, 2, 2, 1, 1 })]
        public void AddAtTest(int[] array, int idx, int[] val, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            LinkedList valList = new LinkedList(val);
            //act 
            list.AddAt(idx, valList);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }
                
        [TestCase(new int[] { 1, 3, 3 }, 1, 2, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 2, 5, new int[] { 1, 1, 5, 1, 1, 1 })]
        public void SetTest(int[] array, int idx, int val, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.Set(idx, val);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2 })]
        [TestCase(new int[] { 1, 7, 12, 42, 8 }, new int[] { 7, 12, 42, 8 })]
        public void RemoveFirstTest(int[] array, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.RemoveFirst();
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 7, 12, 42, 8 }, new int[] { 1, 7, 12, 42 })]
        public void RemoveLastTest(int[] array, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.RemoveLast();
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1 }, 0, new int[] { })]
        [TestCase(new int[] { 1, 2 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 1, 7, 12, 42, 8 }, 2, new int[] { 1, 7, 42, 8 })]
        public void RemoveAtTest(int[] array, int idx, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.RemoveAt(idx);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 1, 2 }, 1, new int[] { 2 })]
        [TestCase(new int[] { 1, 7, 12, 42, 8 }, 3, new int[] { 42, 8 })]
        public void RemoveFirstMultipleTest(int[] array, int n, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.RemoveFirstMultiple(n);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 1, 2 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 1, 7, 12, 42, 8 }, 3, new int[] { 1, 7 })]
        public void RemoveLastMultiple(int[] array, int n, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            //act 
            list.RemoveLastMultiple(n);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 0 }, 0, 1, new int[] { })]
        [TestCase(new int[] { 0, 1, 2 }, 2, 1, new int[] { 0, 1 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 1, 4, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 7, 42, 12, 50 }, 2, 3, new int[] { 1, 2, 50 })]
        public void RemoveAtMultiple(int[] array, int idx, int n, int[] expected)
        {
            //arrange
            LinkedList arrayForTest = new LinkedList(array);
            //act
            arrayForTest.RemoveAtMultiple(idx, n);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}