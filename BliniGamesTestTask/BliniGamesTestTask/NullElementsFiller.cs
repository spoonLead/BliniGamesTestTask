using System;
using System.Collections.Generic;
using System.Text;

namespace BliniGamesTestTask
{
    public class NullElementsFiller
    {

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

        protected static List<int> getIndexesFromNullElements(Object[] arr)
        {
            List<int> indexesFromNullElements = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                    indexesFromNullElements.Add(i);
            }
            return indexesFromNullElements;
        }

        protected static List<GameObject> getConvertedGameObjArrayToList(GameObject[] arr)
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
