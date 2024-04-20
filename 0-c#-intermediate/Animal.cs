using System;


namespace CSharpJourney{

    /*
        I also want to use this Animal class to 
        understand the concept of Composition
    */

    class Animal{

        public readonly string Name;
        public int Age { get; set; }
    
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat(){
            Console.WriteLine("{0} is eating", Name);
        }

        public void Sleep(){
            Console.WriteLine("{0} is sleeping", Name);
        }
    }
}