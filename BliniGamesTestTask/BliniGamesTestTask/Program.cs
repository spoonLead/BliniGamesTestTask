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



            Random rand = new Random(DateTime.Now.Millisecond);

            int a;
            int b;

            if (firstArrayNullIndexes.Count <= replacementElementsFromSecondArray.Count)
            {
                for (int i = 0; i < nullIndexesCount; i++)
                {
                    a = rand.Next(0, firstArrayNullIndexes.Count);
                    b = rand.Next(0, replacementElementsFromSecondArray.Count);

                    firstArray[firstArrayNullIndexes[a]] = replacementElementsFromSecondArray[b];

                    firstArrayNullIndexes.RemoveAt(a);
                    replacementElementsFromSecondArray.RemoveAt(b);
                }
            }
            else
            {
                for (int i = 0; i < replacementElementsCount; i++)
                {
                    a = rand.Next(0, firstArrayNullIndexes.Count);
                    b = rand.Next(0, replacementElementsFromSecondArray.Count);

                    firstArray[firstArrayNullIndexes[a]] = replacementElementsFromSecondArray[b];

                    firstArrayNullIndexes.RemoveAt(a);
                    replacementElementsFromSecondArray.RemoveAt(b);
                }
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
