namespace CSharpJourney{
    class Walkable{

        /*
             This walkable class will be compose by any object 
             that compose the Animal class
        */

        public void Walk(string animalName){
            Console.WriteLine("{0} is walking", animalName);
        }
    }
}