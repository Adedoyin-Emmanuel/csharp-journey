using System;

namespace CSharpJourney{

    /*
    
        My plan is to use this file to practise interfaces. 
        Though I'm comfortable with interfaces in TypeScript
        which is kinda related to that of C#, though the syntax is kinda 
        different especially with creating method signatures in interfaces.

        Interfaces can be used to achieve polymorphism

    */
    class Interfaces{

        public interface IPerson{
            public void Walk(string name);
            string FullName { set; get; }

        }

        class Person(string fullName) : IPerson{

            public string FullName { get; set; } = fullName;

            public void Walk(string name){
                Console.WriteLine(name);
            }
        }
    }
}