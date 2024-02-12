using System;
using System.Collections.Generic;

namespace CSharpJourney{
    class Program2 {
        
        public static void Hello(){
            Console.WriteLine("Hello From Primitive Types");
        }


        public static void PrintArray() {
            int [] numbers = [0, 1, 2];

            for(int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }
        }

        public static void PrintString(){
            string fullName = "Adedoyin Emmanuel";
            const string surName = "Adedoyin";


            Console.WriteLine(surName);
            Console.WriteLine(fullName);


            
        }


        public static void WorkingWithArray(){
            int [] numbers =  [ 1, 2, 3, 4, 5, 6, 7, 8];

            for(int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }

        }

        public static void WorkingWithList(){
            var cars = new List<string>() { "Buggati", "Camary", "Henenssey Venom", "Volvo"};

            foreach (string car in cars){
                Console.WriteLine(car);
            }
        }
    }
}
