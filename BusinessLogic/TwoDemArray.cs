using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class TwoDemArray
    {
        //Define the reference varibel
        int [,] intArray;

        /// <summary>
        /// 2D Initializer
        /// </summary>
        /// <returns></returns>
        public int [,] twoDInitializer()
        {
            intArray = new int[3, 4]
            {
                    {1, 0, 12, -1 },
                    {7, -3, 2, 5 },
                    {-5, -2, 2, 9 }
            };

            return (intArray);
        }

        public int[,] createArray()
        {
            //populate a 2D array
            //Dfeine the size of the array

            int[,] arrAutoCreate = new int[3, 4];

            //Counter

            int counter = 0;

            //Nested for loops
            //outer loop interate through the rows
            //int i is the initializer
            //conditions
            //row++ iterator

            for (int row = 0; row < arrAutoCreate.GetLength(0); row++)
            {
                //Inner loop
                for (int col = 0; col < arrAutoCreate.GetLength(1); col++)
                {
                    //Insert integer into array
                    arrAutoCreate[row, col] = counter;

                    //Inc counter

                    counter++;
                }
            }

            return (arrAutoCreate);
        }


        public string readArray(int[,] arrToRead)
        {
            //Define the string to return

            string contentsOfArray = "";

            //Iterate through the array

            foreach (int element in arrToRead)
            {
                //Insert array contents into the string
                contentsOfArray += string.Format("{0}", element);
            }

            return (contentsOfArray);
        }
    }
}
