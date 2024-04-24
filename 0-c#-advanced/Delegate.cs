using System;

namespace CSharpJourney{

    class PhotoProcessor{
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler){
            var photo = Photo.Load(path);

            filterHandler(photo); 

            photo.Save();
             

        }
    }
}