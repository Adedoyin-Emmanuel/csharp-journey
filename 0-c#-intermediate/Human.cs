using System;


namespace CSharpJourney{

    /*
        Here, the Human class can compose the Animal class,
        we can say, Human has an Animal but not Human is an animal,

        because if tomorrow we create a Fish as an animal, but a fish cannnot walk, so 
        we've to change the animal implementation. So it is safer to make Animal like a service
        class. 
    */

    class Human(Animal animal, Walkable walkable){

        private readonly Animal _animal = animal;
        private readonly Walkable _walkable = walkable;
        
       


    }
}