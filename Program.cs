using System;


namespace CSharpJourney{

    class Program{

        static void Main(string[] args){
            // Console.WriteLine("Hello World!");
            // Program2.Hello();
            // Program2.PrintArray();
            // Program2.PrintString();

            //Program2.WorkingWithArray();

            //Program2.WorkingWithList();

            //Program2.workingWithNumber();


            // Program2.WorkingWithDate();

            //Program2.CreateCSharpIntermediateDirectory();


            var person = new CSharpClasses("Adedoyin Emmanuel", "coding, drumming, travelling") 
            { BirthDate = new DateTime(2005, 9, 14) };

            person.setGirlfriend(true);

            //person.Introduce();



            int calculatorResult = Calculator.Add(1, 2, 3, 4, 5);

            int calculatorResult2 = Calculator.Add([1, 2, 3]);


            //Console.WriteLine(calculatorResult);
            //Console.WriteLine(calculatorResult2);


            var person2 = new Person("Adedoyin Emmanuel", 18, "male", "coding, cooking, cycling, gaming");


            person2.Introduce();



            var employee = new Employee("Adedoyin Emmanuel Adeniyi", 18, "male", "coding, cooking, cycling, gaming");


            employee.Introduce();


        }
    }
}