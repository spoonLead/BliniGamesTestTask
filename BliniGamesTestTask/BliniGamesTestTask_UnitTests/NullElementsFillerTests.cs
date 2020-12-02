using Microsoft.VisualStudio.TestTools.UnitTesting;
using BliniGamesTestTask;
using System.Collections.Generic;

namespace BliniGamesTestTask_UnitTests
{
    [TestClass]
    public class NullElementsFillerTests : NullElementsFiller
    {
        NullElementsFiller filler = new NullElementsFiller();

        [TestMethod]
        public void getIndexesFromNullElements_NullOnTheEdges_04returned()
        {
            //arange
            GameObject[] testArr = new GameObject[5] { null, new GameObject(), new GameObject(), new GameObject(), null };
            List<int> expected = new List<int>() {0, 4};

            //act
            List<int> actual = new List<int>();
            actual = getIndexesFromNullElements(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getIndexesFromNullElements_NullOnTheCenter_123returned()
        {
            //arange
            GameObject[] testArr = new GameObject[5] {new GameObject(), null, null, null, new GameObject()};
            List<int> expected = new List<int>() { 1,2,3 };

            //act
            List<int> actual = new List<int>();
            actual = getIndexesFromNullElements(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getIndexesFromNullElements_OnlyNull_01234returned()
        {
            //arange
            GameObject[] testArr = new GameObject[5] { null, null, null, null, null};
            List<int> expected = new List<int>() { 0, 1, 2, 3, 4};

            //act
            List<int> actual = new List<int>();
            actual = getIndexesFromNullElements(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getIndexesFromNullElements_NoNull_123returned()
        {
            
        }
    }
}
