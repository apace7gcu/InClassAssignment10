using System;
using System.IO;
using DataAccess;


namespace BusinessLogic
{
    public class ManageTextFile
    {
        //Define our Attributes

        private string textFileName;

        private string fileDirectory;

        private string fullDirLocation;

        //Declare reference variable so we can use it in the different methods
        //This is not instanting the class or creasting an instance of the class.
        ReadTextFile passingData;

        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="textFileName"></param>
        /// <param name="fileDirectory"></param>
        public ManageTextFile(string textFileName, string fileDirectory)
        {
            this.textFileName = textFileName;
            this.fileDirectory = fileDirectory;
            fullDirLocation = fileDirectory + @"\" + textFileName;
            //Create an instance of  the class and que the constructor

            passingData = new ReadTextFile();
        }

        /// <summary>
        /// Pass the contents of the text file.
        /// </summary>
        /// <returns></returns>
        public string passingFileContent()
        {
            //Pass the file contents from the Data Access layer to presenysyion layer

            return (passingData.getFileContents(fullDirLocation));
        }

        }



    }
