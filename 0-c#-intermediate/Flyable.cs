namespace CSharpJourney{
    class Flyable{

        /*
             This walkable class will be compose by any object 
             that compose the Animal class
        */

        public void Fly(string animalName){
            Console.WriteLine("{0} is flying", animalName);
        }
    }
}