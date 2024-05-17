using System;


namespace CSharpJourney{


    /**
        Sometime we want to assign a variable null value, but we can't do that with value types like int, double, bool, etc.
        So we use the Nullable<T> generic to indicate that we want to make a variable null.


        When working with Nullable types, we can use the Nullable<> or the ? operator to indicate that a variable is null.

        When also checking for value, we can use the Non Choalescing Operator to test for null values.
    */

     class User
    {

        public string ?Name { get; set; }
        public int ?Age { get; set; }

       
       public void Introduce(){
            Console.WriteLine($"Hi, my name is {Name ?? "John Doe" }. I'm {Age ?? 18 } years old!");
       }

    }
}