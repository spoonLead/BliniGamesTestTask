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
        public void getConvertedGameObjArrayToList_GameObjectArray_GameObjectListReturned()
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
        public void getConvertedGameObjArrayToList_GameObjectArrayWithNullElements_GameObjectListWithNullElementsReturned()
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
        public void getConvertedGameObjArrayToList_GameObjectArrayWithOnlyNullElements_GameObjectListWithOnlyNullElementsReturned()
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
        public void getConvertedGameObjArrayToList_EmptyGameObjectArray_EmptyGameObjectListReturned()
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

        //_________getCountOfGreaterFromIntAndGameObjList_tests_________
        [TestMethod]
        public void getCountOfGreaterFromIntAndGameObjList_Int1GO2_2Returned()
        {
            //arange
            List<int> testIntArr = new List<int> { 1 };
            List<GameObject> testGOArr = new List<GameObject> {new GameObject(), new GameObject()};
            int expected = 2;

            //act
            int actual = getCountOfGreaterFromIntAndGameObjList(testIntArr, testGOArr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCountOfGreaterFromIntAndGameObjList_Int2GO1_2Returned()
        {
            //arange
            List<int> testIntArr = new List<int> { 1, 2 };
            List<GameObject> testGOArr = new List<GameObject> { new GameObject() };
            int expected = 2;

            //act
            int actual = getCountOfGreaterFromIntAndGameObjList(testIntArr, testGOArr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCountOfGreaterFromIntAndGameObjList_Int1GO1_1Returned()
        {
            //arange
            List<int> testIntArr = new List<int> { 1 };
            List<GameObject> testGOArr = new List<GameObject> { new GameObject() };
            int expected = 1;

            //act
            int actual = getCountOfGreaterFromIntAndGameObjList(testIntArr, testGOArr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCountOfGreaterFromIntAndGameObjList_Int0GO1_1Returned()
        {
            //arange
            List<int> testIntArr = new List<int>();
            List<GameObject> testGOArr = new List<GameObject> { new GameObject() };
            int expected = 1;

            //act
            int actual = getCountOfGreaterFromIntAndGameObjList(testIntArr, testGOArr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCountOfGreaterFromIntAndGameObjList_Int1GO0_1Returned()
        {
            //arange
            List<int> testIntArr = new List<int>() { 1 };
            List<GameObject> testGOArr = new List<GameObject>();
            int expected = 1;

            //act
            int actual = getCountOfGreaterFromIntAndGameObjList(testIntArr, testGOArr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCountOfGreaterFromIntAndGameObjList_Int0GO0_0Returned()
        {
            //arange
            List<int> testIntArr = new List<int>();
            List<GameObject> testGOArr = new List<GameObject>();
            int expected = 0;

            //act
            int actual = getCountOfGreaterFromIntAndGameObjList(testIntArr, testGOArr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //___________fillNullElFromFirstArrWithRandElFromSecondArr_tests___________

        static GameObject FA1 = new GameObject();
        static GameObject FA2 = new GameObject();
        

        static GameObject SA1 = new GameObject();
        static GameObject SA2 = new GameObject();
        static GameObject SA3 = new GameObject();

        
        [TestMethod]
        public void fillNullElFromFirstArrWithRandElFromSecondArr_FirstArrNullElCountMoreThanSecondArrEl()
        {

            //arange
            GameObject[] firstArray = new GameObject[6] { FA1, null, null, null, FA2, null };
            GameObject[] secondArray = new GameObject[3] { SA1, SA2, SA3 };

            //act
            fillNullElFromFirstArrWithRandElFromSecondArr(ref firstArray, ref secondArray);

            //assert
            Assert.IsTrue(hasGameObjectArrOneNullElement(firstArray));
        }

        public bool hasGameObjectArrOneNullElement(GameObject[] arr)
        {
            int nullElementCount = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                    nullElementCount++;
            }
            if (nullElementCount == 1)
                return true;
            else
                return false;
        }

        [TestMethod]
        public void fillNullElFromFirstArrWithRandElFromSecondArr_FirstArrNullElCountLessThanSecondArrEl()
        {
            
        }

        [TestMethod]
        public void fillNullElFromFirstArrWithRandElFromSecondArr_FirstArrNullElCountEqualsSecondArrEl_AllItemsAreNotNull()
        {
            //arange
            GameObject[] firstArray = new GameObject[5] { FA1, null, null, null, FA2 };
            GameObject[] secondArray = new GameObject[3] { SA1, SA2, SA3 };

            //act
            fillNullElFromFirstArrWithRandElFromSecondArr(ref firstArray, ref secondArray);

            //assert
            CollectionAssert.AllItemsAreNotNull(firstArray);
        }

        [TestMethod]
        public void fillNullElFromFirstArrWithRandElFromSecondArr_FirstArrNullElCountEqualsSecondArrEl_AllItemsAreUnique()
        {
            //arange
            GameObject[] firstArray = new GameObject[5] { FA1, null, null, null, FA2 };
            GameObject[] secondArray = new GameObject[3] { SA1, SA2, SA3 };

            //act
            fillNullElFromFirstArrWithRandElFromSecondArr(ref firstArray, ref secondArray);

            //assert
            CollectionAssert.AllItemsAreUnique(firstArray);
        }
    }
}
