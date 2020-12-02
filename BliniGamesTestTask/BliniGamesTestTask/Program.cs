using System;
using System.Collections.Generic;

namespace BliniGamesTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject FA1 = new GameObject();
            GameObject FA2 = new GameObject();
            GameObject[] firstArray = new GameObject[6] { FA1, null, FA2, null,  null, null};


            GameObject SA1 = new GameObject();
            GameObject SA2 = new GameObject();
            GameObject SA3 = new GameObject();
            GameObject[] secondArray = new GameObject[3] { SA1, SA2, SA3 };


            fillNullElFromFirstArrWithRandElFromSecondArr(ref firstArray, ref secondArray);


            Console.ReadKey();
        }

        public static void fillNullElFromFirstArrWithRandElFromSecondArr(ref GameObject[] firstArray, ref GameObject[] secondArray)
        {
            List<int> firstArrayNullIndexes = getIndexesFromNullElements(firstArray);
            int nullIndexesCount = firstArrayNullIndexes.Count;

            List<GameObject> replacementElementsFromSecondArray = getConvertedGameObjArrayToList(secondArray);
            int replacementElementsCount = replacementElementsFromSecondArray.Count;



            int fillingIterationCount;
            if (firstArrayNullIndexes.Count <= replacementElementsFromSecondArray.Count)
                fillingIterationCount = nullIndexesCount;
            else
                fillingIterationCount = replacementElementsCount;



            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < fillingIterationCount; i++)
            {
                int currReplacebleElement = rand.Next(0, firstArrayNullIndexes.Count);
                int currReplacingElement = rand.Next(0, replacementElementsFromSecondArray.Count);

                firstArray[firstArrayNullIndexes[currReplacebleElement]] = replacementElementsFromSecondArray[currReplacingElement];

                firstArrayNullIndexes.RemoveAt(currReplacebleElement);
                replacementElementsFromSecondArray.RemoveAt(currReplacingElement);
            }
        }

        public static List<int> getIndexesFromNullElements(Object[] arr)
        {
            List<int> indexesFromNullElements = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                    indexesFromNullElements.Add(i);
            }
            return indexesFromNullElements;
        }

         public static List<GameObject> getConvertedGameObjArrayToList(GameObject[] arr)
        {
            List<GameObject> convertedArrayToList = new List<GameObject>();
            foreach (GameObject obj in arr)
            {
                convertedArrayToList.Add(obj);
            }
            return convertedArrayToList;
        }
    }
}
