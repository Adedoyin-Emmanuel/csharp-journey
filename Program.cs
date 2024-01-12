using System;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello world");

            //learning variables

            byte x = 10;

            short z = 500;

            long y = 5000;

            char c = 'a';

            string name = "Adedoyin Emmanuel";

            var firstName = "Adedoyin";
            var secondName = "Emmanuel";

            int age = 18;

            bool isAdult = age >= 18 ;
            float PI = 3.142f;


            if(isAdult && age  >= 18){
                Console.WriteLine("User is eligible to vote!");
            }else{
                Console.WriteLine("User is not eligible to vote!");
            }
            

            for(short i = 0; i < 28; i++){
                Console.WriteLine("Hello world \n");
            }



            Console.WriteLine(x);
            Console.WriteLine(z);

            Console.WriteLine(y);
            Console.WriteLine(c);
            Console.WriteLine(name);
            Console.WriteLine(isAdult);




        }
    }
}