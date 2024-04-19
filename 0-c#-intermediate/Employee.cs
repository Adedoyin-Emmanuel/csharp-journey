using System;


namespace CSharpJourney{


    /*
        I will use this class to practise Inheritance
    */


    class Employee(string name, int age, string gender, string hobbies) : Person(name, age, gender, hobbies) {

        public override void Introduce(){
            Console.WriteLine("I'm an employee");
            base.Introduce(); // this will call the parent Introduce method.

            /*
                The base() is just like calling the super keyword in JavaScript or TypeScript. 
                It wasn't difficult to wrap my head around it.
            */
        }


        
    }
}