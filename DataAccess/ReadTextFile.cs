using System;
using System.IO;

namespace DataAccess
{
    public class ReadTextFile
    {
        //Define Attributes
        public string fileContents { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fileContents"></param>
        public ReadTextFile()
        {
            //Set file contents to empty
            this.fileContents = "";
        }

        /// <summary>
        /// Return the contents of the text file
        /// </summary>
        /// <returns></returns>
        public string getFileContents(string fullDirLocation)
        {
            //Reads in text file

            using (StreamReader file = new StreamReader(fullDirLocation))
            {
                fileContents = file.ReadToEnd();
            }

            return (fileContents);
        }
    }
}
