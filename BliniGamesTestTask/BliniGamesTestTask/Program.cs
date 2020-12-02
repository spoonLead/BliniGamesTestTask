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
            GameObject[] firstArray = new GameObject[5] { FA1, null, FA2, null, null };



            GameObject SA1 = new GameObject();
            GameObject SA2 = new GameObject();
            GameObject SA3 = new GameObject();
            GameObject[] secondArray = new GameObject[3] {SA1, SA2, SA3};


            
            List<GameObject> firstArrayNulleble = new List<GameObject>();
            foreach( GameObject obj in firstArray)
            {
                if (obj == null)
                    firstArrayNulleble.Add(obj);
            }
            int nullElementsCount = firstArrayNulleble.Count;


            List<GameObject> replacementElementsFromSecondArray = new List<GameObject>();
            foreach (GameObject obj in secondArray)
            {
                replacementElementsFromSecondArray.Add(obj);
            }
            int replacementElementsCount = replacementElementsFromSecondArray.Count;






            Console.ReadKey();

        }
    }
}
