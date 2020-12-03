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
            GameObject[] firstArray = new GameObject[5] { FA1, null, null, null, FA2,};


            GameObject SA1 = new GameObject();
            GameObject SA2 = new GameObject();
            GameObject SA3 = new GameObject();
            GameObject[] secondArray = new GameObject[3] { SA1, SA2, SA3 };


            NullElementsFiller.fillNullElFromFirstArrWithRandElFromSecondArr(ref firstArray, ref secondArray);


            Console.ReadKey();
        }
    }
}
