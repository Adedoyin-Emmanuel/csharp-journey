﻿using System;


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

            person.Introduce();

            person.setGirlfriend(true);

            person.Introduce();


        }
    }
}