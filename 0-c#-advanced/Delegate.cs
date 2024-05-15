using System;

namespace CSharpJourney{

    class PhotoProcessor{

        public void Process(string path, Action<Photo> filterHandler){

            // It worked, I'm soo happy. I read Microsoft docs on how to use the Action delegate
            var photo = Photo.Load(path);

            filterHandler(photo); 

            photo.Save();
            
        }
    }
}