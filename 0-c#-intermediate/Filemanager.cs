using System;
using System.IO;

namespace CSharpJourney
{

    class FileManager
    {



        public void CreateCsharpAdvancedDirectory(string filename)
        {
            var directory = new DirectoryInfo(filename);
            directory.Create();
        }



        public void CreateCsharpAdvancedFile(string filename){
            var file = new FileInfo("0-c#-advanced" + filename);

            file.Create();
        }
    }
}