using System;
using System.IO;

namespace CSharpJourney
{

    class FileManager
    {


        public void CreateCsharpAdvancedDirectory(string filename)
        {
           try
           {
            var directory = new DirectoryInfo(filename);
            directory.Create();
           }catch(Exception e)
           {
            Console.WriteLine(e);
           }finally{
            Console.WriteLine("{0} created successfully 🚀", filename);
           }
        }



        public void CreateCsharpAdvancedFile(string filename){
            try
            {
                var file = new FileInfo("0-c#-advanced/" + filename);

                file.Create();
            }
            catch(Exception e){
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("{0} created successfully 🚀", filename);
            }
        }
    }
}