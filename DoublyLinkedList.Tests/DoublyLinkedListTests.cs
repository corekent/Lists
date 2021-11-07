using NUnit.Framework;

namespace DoublyLinkedList.Tests
{
    public class DoublyLinkedListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //arrange
        //act
        //assert
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 2 }, 2)]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5)]
        public void GetLengthTest(int[] array, int expected)
        {
            //arrange
            DoublyLinkedList list = new DoublyLinkedList(array);
            //act 
            int actual = list.GetLength();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void ToArrayTest(int[] array, int[] expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, 0, new int[] { 0 })]
        [TestCase(new int[] { 1, 2 }, 2, new int[] { 2, 1, 2 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5, new int[] { 5, 1, 1, 1, 1, 1 })]             
        public void AddFirstTest(int[] array, int val, int[] expected)
        {
            //arrange
            DoublyLinkedList list = new DoublyLinkedList(array);
            //act 
            list.AddFirst(val);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { -2, -1, 0 }, new int[] { -2, -1, 0, 1, 2 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 2, 2 }, new int[] { 2, 2, 1, 1, 1, 1, 1 })]
        public void AddFirstTest(int[] array, int[] val, int[] expected)
        {
            //arrange
            DoublyLinkedList list = new DoublyLinkedList(array);
            DoublyLinkedList valList = new DoublyLinkedList(val);
            //act 
            list.AddFirst(valList);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
            //act 
            list.AddLast(val);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
            DoublyLinkedList valList = new DoublyLinkedList(val);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
            DoublyLinkedList valList = new DoublyLinkedList(val);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
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
            DoublyLinkedList list = new DoublyLinkedList(array);
            //act 
            list.RemoveLastMultiple(n);
            int[] actual = list.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 0 }, 0, 1, new int[] { })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 1, 4, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 7, 42, 12, 50 }, 2, 3, new int[] { 1, 2, 50 })]
        public void RemoveAtMultiple(int[] array, int idx, int n, int[] expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            arrayForTest.RemoveAtMultiple(idx, n);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1 }, 1, 0)]
        [TestCase(new int[] { 1, 2, 3 }, 3, 2)]
        [TestCase(new int[] { 1, 7, 12, 42, 8, 12 }, 12, 2)]
        public void RemoveFirstTest(int[] array, int val, int expected)
        {
            //arrange
            DoublyLinkedList list = new DoublyLinkedList(array);
            //act             
            int actual = list.RemoveFirst(val);
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 0 }, 0, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 2, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 3, 0)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 42, 3)]
        public void RemoveAll(int[] array, int val, int expected)
        {
            //arrange
            DoublyLinkedList list = new DoublyLinkedList(array);
            //act            
            int actual = list.RemoveAll(val);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, "yes")]
        [TestCase(new int[] { 0, 1, 2 }, 3, "no")]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 42, "yes")]
        public void ContainsTest(int[] array, int val, string expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            string actual = arrayForTest.Contains(val);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 2, 2)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 42, 1)]
        public void IndexOfTest(int[] array, int val, int expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int actual = arrayForTest.IndexOf(val);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 0)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 1)]
        public void GetFirstTest(int[] array, int expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int actual = arrayForTest.GetFirst();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 2)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 42)]
        public void GetLastTest(int[] array, int expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int actual = arrayForTest.GetLast();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 1, 1)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 3, 42)]
        public void GetTest(int[] array, int index, int expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int actual = arrayForTest.Get(index);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 0, 1, 2 }, new int[] { 2, 1, 0 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
        public void ReverseTest(int[] array, int[] expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            arrayForTest.Reverse();
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 2)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 50)]
        public void MaxTest(int[] array, int expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int actual = arrayForTest.Max();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { -5, 0, 1, 2 }, -5)]
        [TestCase(new int[] { 1, 42, 7, -12, 42, 12, 50, 42 }, -12)]
        public void MinTest(int[] array, int expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int actual = arrayForTest.Min();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 2)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 5)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int actual = arrayForTest.IndexOfMax();
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 0)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42, 0 }, 7)]
        public void IndexOfMinTest(int[] array, int expected)
        {
            //arrange
            DoublyLinkedList arrayForTest = new DoublyLinkedList(array);
            //act
            int actual = arrayForTest.IndexOfMin();
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
