using System;
using System.Collections.Generic;
using System.Text;

namespace BliniGamesTestTask
{
    public class NullElementsFiller
    {

        public static void fillNullElFromFirstArrWithRandElFromSecondArr(ref GameObject[] firstArray, ref GameObject[] secondArray)
        {
            List<int> firstArrayNullIndexes = getListOfIndexesFromNullElementsInArr(firstArray);
            List<GameObject> replacementElementsFromSecondArray = getConvertedGameObjArrayToList(secondArray);


            int fillingIterationCount = getCountOfSmallerFromIntAndGameObjList(firstArrayNullIndexes, replacementElementsFromSecondArray);
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < fillingIterationCount; i++)
            {
                int currReplacebleElement = rand.Next(0, firstArrayNullIndexes.Count);  //Рандомный выбор элемента, который будет заменяться в первом массиве из оставшихся в нем элементов null
                int currReplacingElement = rand.Next(0, replacementElementsFromSecondArray.Count);   //Рандомны выбор элемента, которым будет происходить замена из не использовавшихся для замены элементов второго массива

                firstArray[firstArrayNullIndexes[currReplacebleElement]] = replacementElementsFromSecondArray[currReplacingElement];

                firstArrayNullIndexes.RemoveAt(currReplacebleElement);  //Удаление индекса null элемента (который был заменен в текущей итерации) из массива индексов null элементов первого массива
                replacementElementsFromSecondArray.RemoveAt(currReplacingElement);  //Удаление использованного заменяющего элемента из копии второго массива
            }
        }

        protected static List<int> getListOfIndexesFromNullElementsInArr(Object[] arr)
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

        protected static int getCountOfSmallerFromIntAndGameObjList(List<int> firstList, List<GameObject> secondList)
        {
            if (firstList.Count <= secondList.Count)
                return firstList.Count;
            else
                return secondList.Count;

        }
    }
}
