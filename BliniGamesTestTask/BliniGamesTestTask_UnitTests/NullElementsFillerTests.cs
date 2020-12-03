using Microsoft.VisualStudio.TestTools.UnitTesting;
using BliniGamesTestTask;
using System.Collections.Generic;

namespace BliniGamesTestTask_UnitTests
{
    [TestClass]
    public class NullElementsFillerTests : NullElementsFiller
    {
        //_________getIndexesFromNullElements_tests________
        [TestMethod]
        public void getIndexesFromNullElements_NullOnTheEdges_04Returned()
        {
            //arange
            GameObject[] testArr = new GameObject[5] { null, new GameObject(), new GameObject(), new GameObject(), null };
            List<int> expected = new List<int>() {0, 4};

            //act
            List<int> actual = new List<int>();
            actual = getListOfIndexesFromNullElementsInArr(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getIndexesFromNullElements_NullOnTheCenter_123Returned()
        {
            //arange
            GameObject[] testArr = new GameObject[5] {new GameObject(), null, null, null, new GameObject()};
            List<int> expected = new List<int>() { 1,2,3 };

            //act
            List<int> actual = new List<int>();
            actual = getListOfIndexesFromNullElementsInArr(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getIndexesFromNullElements_OnlyNull_01234Returned()
        {
            //arange
            GameObject[] testArr = new GameObject[5] { null, null, null, null, null};
            List<int> expected = new List<int>() { 0, 1, 2, 3, 4};

            //act
            List<int> actual = new List<int>();
            actual = getListOfIndexesFromNullElementsInArr(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getIndexesFromNullElements_NoNull_EmptyListReturned()
        {
             //arange
            GameObject[] testArr = new GameObject[5] { new GameObject(), new GameObject(), new GameObject(), new GameObject(), new GameObject() };
            List<int> expected = new List<int>();

            //act
            List<int> actual = new List<int>();
            actual = getListOfIndexesFromNullElementsInArr(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }



        //________getConvertedGameObjArrayToList_tests_________
        [TestMethod]
        public void getConvertedGameObjArrayToList_GameObjectArray_GameObjectList()
        {
            //arange
            GameObject TGO1 = new GameObject();
            GameObject TGO2 = new GameObject();
            GameObject TGO3 = new GameObject();
            GameObject[] testArr = new GameObject[3] {TGO1, TGO2, TGO3};
            List<GameObject> expected = new List<GameObject>() {TGO1, TGO2, TGO3 };

            //act
            List<GameObject> actual = new List<GameObject>();
            actual = getConvertedGameObjArrayToList(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getConvertedGameObjArrayToList_GameObjectArrayWithNullElements_GameObjectListWithNullElements()
        {
            //arange
            GameObject TGO1 = new GameObject();
            GameObject[] testArr = new GameObject[3] {TGO1, null, null };
            List<GameObject> expected = new List<GameObject>() {TGO1, null, null};

            //act
            List<GameObject> actual = new List<GameObject>();
            actual = getConvertedGameObjArrayToList(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getConvertedGameObjArrayToList_GameObjectArrayWithOnlyNullElements_GameObjectListWithOnlyNullElements()
        {
            //arange
            GameObject TGO1 = new GameObject();
            GameObject[] testArr = new GameObject[3] { TGO1, null, null };
            List<GameObject> expected = new List<GameObject>() { TGO1, null, null };

            //act
            List<GameObject> actual = new List<GameObject>();
            actual = getConvertedGameObjArrayToList(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getConvertedGameObjArrayToList_EmptyGameObjectArray_EmptyGameObjectList()
        {
            //arange
            GameObject[] testArr = new GameObject[0];
            List<GameObject> expected = new List<GameObject>();

            //act
            List<GameObject> actual = new List<GameObject>();
            actual = getConvertedGameObjArrayToList(testArr);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

       
    }
}
