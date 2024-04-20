using System;


namespace CSharpJourney{

    
    class Bird(Animal animal, Flyable flyable){

        /*
            I guess this new way of passing parameters to 
            class not using the CTOR snippet is a new stuff.
            Mosh didn't mention this in the C# classes course.
        */
        private readonly Animal _animal = animal;
        private readonly Flyable _flyable = flyable;

    }
    
}