using System;
using Microsoft.VisualBasic;


namespace CSharpJourney{

    class LambdaExpression{

        public int Add(int num1, int num2){
            return num1 + num2;
        }


        Func<int, int, int> AddWithLambda = (int num1, int num2) => num1 + num2;


        public int Subtract(int num1, int num2){
            return num1 - num2;
        }


        Func<int, int, int> SubtractWithLambda = (int num1, int num2) => num1 - num2;

        



    }
}