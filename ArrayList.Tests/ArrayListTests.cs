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

        [TestCase(0, new int[] { })]
        //[TestCase(1, new int[] { 1 })]
        [TestCase(2, new int[] { 1, 2, 3, 4 })]
        public void ToArrayTest(int index, int [] expected)
        {
            //arrange
            ArrayList arrayForTest = TestData.ForTests(index);
            //act
            int[] actual = arrayForTest.ToArray();
            //assert
            Assert.AreEqual(actual, expected);
        }




    }
}