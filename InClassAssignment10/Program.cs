using System;
using System.IO;
using BusinessLogic;


namespace InClassAssignment10
{ 
    /*
     * Amanda Pace
     * CST-117 Bill Hughes
     * 
     * This is a text reader that parses a string for certain requirements.
     * 
     * This assignment was done together in class.    
     */
    class Program
    {
        static void Main(string[] args)
        {
            //first, read in a text file

            ManageTextFile newContent = new ManageTextFile("InClassAssignment10.txt", Directory.GetCurrentDirectory() + @"\..\DataFile");

            string fileContent = newContent.passingFileContent();

            // Now Parse out the string and return the matches

            ParseString getCount = new ParseString(fileContent);

            int numWords = getCount.getWordCount();

            Console.WriteLine("There are {0} words that end in t or e", numWords);

            Console.ReadLine();





            //-------------------------------------------
            //Define our array

            TwoDemArray newArrayContent = new TwoDemArray();

            int[,] arrNew = newArrayContent.createArray();


            //Get the string and print it using foreach loops

            Console.WriteLine("Array Contents: {0}", newArrayContent.readArray(arrNew));

            Console.ReadLine();
        }
    }
}
