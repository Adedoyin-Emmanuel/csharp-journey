using System;

namespace CSharpJourney{


    class CSharpClasses{



         string name;
        long age;
        string hobbies;
        


        /*
            So based on what I learnt from Mosh Hamedani

            A C# class can have multiple constructors but the 
            constructors should have different signatures.

            Signatures as in the constructor 


            Let's try to break that and see if the C# compiler
            will complain.  Oh yeah, it is complaining 🤣

        */
        // public CSharpClasses(){
        //     Console.WriteLine("Hello from the constructor");
        // }

        // public CSharpClasses(string name){
        //     Console.WriteLine("Hello from the constructor, my name is {0}", name);
        // }


        // // Yet another constructor but with a different signature this case a datatypee
        // public CSharpClasses(int age){
        //     Console.WriteLine("Hello from the constructor, my age is {0}", age);
        // }



        public CSharpClasses(string name, long age, string hobbies){

            this.name = name;
            this.age = age;

            this.hobbies = hobbies;

        }



        public void Introduce (){
            Console.WriteLine("Hi, my name is {0}. I'm {1} years old. I love {2}", name, age, hobbies);
        }


    }
}