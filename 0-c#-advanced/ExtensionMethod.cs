using System;



namespace CSharpJourney
{

    /**
        So what are extension methods?

        Extension methods enables you to kinda extend a predefined class

        by adding more methods to the class without modifiying the original class.

        The class and methods are static and then the first parameter of the method specifies

        type that method operates on. Preceded by the `this` keyword.



    */
    static class StringExtension{

        public static int GetWordCount(this string str){
             string[] totalWords = str.Split(' ');

             return totalWords.Length;
        }

    }


    /**
        This extension method is going to be on Integers

        I will try to create some math methods and then add them to the int type
    */


    static class IntExtension{

        
        public static int Add(this int[] numbers, params int[] additionalNumbers){

            int sum = 0;

            foreach(int number in numbers){
                sum += number;
            }


            foreach(int number in additionalNumbers){
                sum += number;
            }

            return sum;
        }


        public static int Square(this int number) => number * number;


    }

}