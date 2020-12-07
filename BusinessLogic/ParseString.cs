using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class ParseString
    {
        //Define Attributes

        private bool isWord;
        public int wordCount { get; private set; }

        public string strToParse { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="strToParse"></param>
        public ParseString(string strToParse)
        {
            this.isWord = false;
            this.wordCount = 0;
            this.strToParse = strToParse;
        }

        /// <summary>
        /// Removes all punctuation from string
        /// </summary>
        /// <param name="fileContentsVal"></param>
        /// <returns></returns>
        private string parsePunctuation(string fileContentsVal)
        {
            //Stripping out the punctuation

            string strResults = Regex.Replace(fileContentsVal, @"[^\w\d\s]", "");

            return strResults;
        }

        public int getWordCount()
        {
            string fileContents = "";

            //First, remove punctuation

            fileContents = parsePunctuation(strToParse);

            //Get all the words into an array

            string[] arrIndWords = parseWords(fileContents);

            //Iterate through the array and detect last char

            foreach (string word in arrIndWords)
            {
                //Now determine if word ends in t or e

                if (wordDetector(word))
                {
                    wordCount++;
                }

            }

            return (wordCount);
        }

        private bool wordDetector(string word)
        {
            //Reset the bool to false

            isWord = false;

            //So we can test in lower case only

            word = word.ToLower();

            //Get last char of word

            char lastChar = word.Last();

            //Test char

            if (lastChar == 't' || lastChar == 'e')
            {
                isWord = true;
            }
            return isWord;

        }

        private string[] parseWords(string strToParse)
        {
            //Define a 1D array with reference variable called arrWord

            string[] arrWord = strToParse.Split( );

            return arrWord;
        }
    }
}
