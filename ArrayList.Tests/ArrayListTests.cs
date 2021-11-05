using NUnit.Framework;

namespace ArrayList.Tests
{
    public class ArrayListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //arrange
        //act
        //assert

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 2 }, 2)]
        public void GetLengthTest(int[] array, int expected)
        {
            //arrange
            ArrayList arr = new ArrayList(array);
            //act
            int actual = arr.GetLength();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void ToArrayTest(int[] array, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, 1, new int[] { 1 })]
        [TestCase(new int[] { 0 }, 1, new int[] { 1, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, new int[] { 0, 1, 2, 3, 4 })]
        public void AddFirstTest(int[] array, int value, int[] expected)
        {
            //arrange            
            ArrayList arrayForTest = new ArrayList(array);
            //act            
            arrayForTest.AddFirst(value);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 3 }, new int[] { 1, 2 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 42, 12, 7 }, new int[] { 42, 12, 7, 1, 2, 3, 4 })]
        public void AddFirstTest(int[] arr, int[] valArray, int[] expected)
        {
            //arrange            
            ArrayList arrayForTest = new ArrayList(arr);
            ArrayList ValArrayForTest = new ArrayList(valArray);
            //act            
            arrayForTest.AddFirst(ValArrayForTest);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, 1, new int[] { 1 })]
        [TestCase(new int[] { 0 }, 1, new int[] { 0, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 5, new int[] { 1, 2, 3, 4, 5 })]
        public void AddLastTest(int[] array, int value, int[] expected)
        {
            //arrange            
            ArrayList arrayForTest = new ArrayList(array);
            //act            
            arrayForTest.AddLast(value);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { }, new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1 }, new int[] { 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 42, 12, 7 }, new int[] { 1, 2, 3, 4, 42, 12, 7 })]
        public void AddLastTest(int[] arr, int[] valArray, int[] expected)
        {
            //arrange            
            ArrayList arrayForTest = new ArrayList(arr);
            ArrayList ValArrayForTest = new ArrayList(valArray);
            //act            
            arrayForTest.AddLast(ValArrayForTest);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(0, 1, new int[] { }, new int[] { 1 })]
        [TestCase(0, 1, new int[] { 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, 2, new int[] { 1, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(2, 3, new int[] { 1, 2 }, new int[] { 1, 2, 3 })]
        public void AddAtTest(int idx, int value, int[] array, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.AddAt(idx, value);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, new int[] { 0 }, new int[] { 1 })]
        [TestCase(1, 1, new int[] { 0, 2 }, new int[] { 0, 1 })]
        [TestCase(1, 1, new int[] { 0, 2, 2 }, new int[] { 0, 1, 2 })]
        public void SetTest(int idx, int value, int[] array, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.Set(idx, value);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { 0, 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        public void RemoveFirstTest(int[] array, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.RemoveFirst();
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { 0, 1 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        public void RemoveLastTest(int[] array, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.RemoveLast();
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, new int[] { })]
        [TestCase(new int[] { 0, 1 }, 1, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 5, new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11 })]
        public void RemoveAtTest(int[] array, int idx, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.RemoveAt(idx);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 1, new int[] { })]
        [TestCase(new int[] { 0, 1, 2 }, 1, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 4, new int[] { 1 })]
        public void RemoveFirstMultiple(int[] array, int n, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.RemoveFirstMultiple(n);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 1, new int[] { })]
        [TestCase(new int[] { 0, 1, 2 }, 1, new int[] { 0, 1 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 4, new int[] { 1 })]
        public void RemoveLastMultiple(int[] array, int n, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.RemoveLastMultiple(n);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, 1, new int[] { })]
        [TestCase(new int[] { 0, 1, 2 }, 2, 1, new int[] { 0, 1 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 1, 4, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 7, 42, 12, 50 }, 2, 3, new int[] { 1, 2, 50 })]
        public void RemoveAtMultiple(int[] array, int idx, int n, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.RemoveAtMultiple(idx, n);
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 2, 1)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 42, 3)]
        public void RemoveAll(int[] array, int val, int expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int actual = arrayForTest.RemoveAll(val);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, "yes")]
        [TestCase(new int[] { 0, 1, 2 }, 3, "no")]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 42, "yes")]
        public void ContainsTest(int[] array, int val, string expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
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
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int actual = arrayForTest.IndexOf(val);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 2)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 42)]
        public void GetLastTest(int[] array, int expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int actual = arrayForTest.GetLast();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 0)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 1)]
        public void GetFirstTest(int[] array, int expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int actual = arrayForTest.GetFirst();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 1, 1)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 3, 42)]
        public void GetTest(int[] array, int index, int expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
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
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.Reverse();
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 2)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 50)]
        public void FindMaxElementTest(int[] array, int expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int actual = arrayForTest.FindMaxElement();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 0)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 1)]
        public void FindMinElementTest(int[] array, int expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int actual = arrayForTest.FindMinElement();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 2)]
        [TestCase(new int[] { 1, 42, 7, 42, 12, 50, 42 }, 5)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
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
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int actual = arrayForTest.IndexOfMin();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 0, 3, 2 }, new int[] {  0, 2, 3 })]
        [TestCase(new int[] { 42, 12, 5, 89 }, new int[] { 5, 12, 42, 89 })]
        public void SortTest(int[] array, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.Sort();
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 0, 3, 2 }, new int[] { 3, 2, 0 })]
        [TestCase(new int[] { 42, 12, 5, 89 }, new int[] { 89, 42, 12, 5 })]
        public void SortDeskTest(int[] array, int[] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            arrayForTest.SortDesk();
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

    }  
}