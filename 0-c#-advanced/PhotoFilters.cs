using System;

namespace CSharpJourney{

    class PhotoFilters{

        public void ApplyBrightness(Photo photo){

            Console.WriteLine("Applying brightness");
        }


        public void ApplySaturation(Photo photo){
            Console.WriteLine("Applying saturation");
        }


        public void ApplyOpacity(Photo photo){
            Console.WriteLine("Applying opacity");
        }
    }
}