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


            // person2.Introduce();

            // person2.Walk();




            var employee = new Employee("Adedoyin Emmanuel Adeniyi", 18, "male", "coding, cooking, cycling, drumming, gaming, travelling");


            // employee.Introduce();

            // employee.Walk();


            // employee.Work("SquadCo"); // John CTO at SquadCo the C# guy. I love that guy ngl.




            // Let me flex my C# skills right now, time to be a hero.

            Employee henqsoft = new Employee("Fasakin Henry", 17, "male", "coding, designing, cooking, cycling, listening to music, drumming");


            // henqsoft.Introduce();


            // henqsoft.Work("Facebook");

            // henqsoft.InRelationship = false;


            // henqsoft.Work("Twitter");


            // henqsoft.InRelationship = true;


            // henqsoft.GetRelationshipStatus(); 







            // It is time to flex it again

            Employee emmysoft = new Employee("Adedoyin Emmanuel", 18, "male", "coding, cooking, cycling, listening to music, drumming, gaming, travelling");


            // emmysoft.Introduce();



            // emmysoft.Work("Google");

            // emmysoft.Work("Clipsave"); 



            // emmysoft.Work("Apple");

            // emmysoft.Work("Amazon");

            // emmysoft.InRelationship = false;

            // emmysoft.GetRelationshipStatus();


            // emmysoft.Work("Microsoft");

            // emmysoft.InRelationship = true;

            // emmysoft.GetRelationshipStatus();




            var circle = new Circle("circle", 20, 20);


            //circle.Draw();


            var logger = new Logger();


            var dbMigrator = new Dbmigrator(logger);

            var installer = new Installer(logger);


            dbMigrator.MigrateDatabase();


            installer.Install();



            


            








        }
    }
}