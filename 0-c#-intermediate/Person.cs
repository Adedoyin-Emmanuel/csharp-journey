using System;

namespace CSharpJourney{


    /**
        I will use this person class to practice Inheritance. While 
        Inheritance is not specific to C#, there are some keywords 
        that are reserved in C# for the purpose of OOP. I will also be
        exploring those keywords. After that, I will practise composition 
        and then polymorphism.
    */

    class Person{

        public readonly string name;
        public readonly string gender;
        public int age;
        public string hobbies;


        
        public Person(string name, int age, string gender, string hobbies){
            this.name = name;
            this.age = age;
            this.hobbies = hobbies;
            this.gender = gender;

            
        }


        public virtual void Introduce(){
            Console.WriteLine("Hello, My name is {0}, I'm a {1}, I'm {2} years old. I love {3}.", name, gender, age, hobbies);
        }

    }
}