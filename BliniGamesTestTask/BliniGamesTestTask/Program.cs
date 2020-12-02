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



            List<int> firstArrayNullIndexes = new List<int>();
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == null)
                    firstArrayNullIndexes.Add(i);
            }

            int nullIndexesCount = firstArrayNullIndexes.Count;


            List<GameObject> replacementElementsFromSecondArray = new List<GameObject>();
            foreach (GameObject obj in secondArray)
            {
                replacementElementsFromSecondArray.Add(obj);
            }
            int replacementElementsCount = replacementElementsFromSecondArray.Count;



            Random rand = new Random(DateTime.Now.Millisecond);

            int a;
            int b;
            
            if(firstArrayNullIndexes.Count <= replacementElementsFromSecondArray.Count)
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
            
           



            Console.ReadKey();

        }
    }
}
