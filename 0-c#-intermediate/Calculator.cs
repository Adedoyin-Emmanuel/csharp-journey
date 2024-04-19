using System;


namespace CSharpJourney{
    

     class Calculator{

        static public int Add(params int[] numbers){
             int result = 0;

            foreach(var number in numbers){
                result += number;
            }

            return result;
        }
    }
}