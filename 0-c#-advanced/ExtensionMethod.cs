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

}