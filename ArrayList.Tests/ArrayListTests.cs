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
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4})]
        public void ToArrayTest(int[] array, int [] expected)
        {
            //arrange
            ArrayList arrayForTest = new ArrayList(array);
            //act
            int[] actual = arrayForTest.ToArray();            
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { }, 1, new int[] { 1 })]
        [TestCase(new int[] { 0 }, 1, new int[] { 1 , 0})]
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




    }
}