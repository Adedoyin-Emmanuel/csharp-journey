using System;


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

            Console.WriteLine(fullName);
        }
    }
}
