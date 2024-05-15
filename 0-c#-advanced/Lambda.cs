using System;
using Microsoft.VisualBasic;


namespace CSharpJourney{

    /*
        You will not believe I was calling it Lambada instead of Lambda.

        This my Yoruba ehen 🤣 🤣. It was until I asked ChatGpt to explain what Lambada expressions are
        and it told me that it is a Lambda expression. I was like, "Oh, I see". 

        So Lambda expressions makes use write clean elegant code unlike the primitive way of doing things

        It is kinda similar to arrow functions in JavaScript/TypeScript

        const square = x => x * x;

        Just that in C#, you've to use a delegate, most times the Func and Action delegate


        For example

        public Func<int, int> square = n => n * n;
    */

    class LambdaExpression{

        public int Add(int num1, int num2){
            return num1 + num2;
        }


        public Func<int, int, int> AddWithLambda = (int num1, int num2) => num1 + num2;


        public int Subtract(int num1, int num2){
            return num1 - num2;
        }


        public Func<int, int, int> SubtractWithLambda = (int num1, int num2) => num1 - num2;


    }
}