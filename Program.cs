using System;
using System.Threading.Tasks;


namespace CSharpJourney{

    class Program{


         static async Task  FetchTodo(){
            var todosService = new Todos();
            var todos = await todosService.GetTodos();

            if (todos != null)
            {
                foreach (var todo in todos)
                {
                    Console.WriteLine($"ID: {todo.id}, Title: {todo.title}, Completed: {todo.completed}");
                }
            }
            else
            {
                Console.WriteLine("No todos fetched.");
            }


        }

         static async Task Main(string[] args)
        {
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


            //dbMigrator.MigrateDatabase();


            //installer.Install();

            var emmanuel = new Animal("human", 18);
            var walkable = new Walkable();
            var human = new Human(emmanuel, walkable);




            var flyable = new Flyable();
            var swimable = new Swimable();
            var birdAnimal = new Animal("bird", 2);
            var bird = new Bird(birdAnimal, flyable);
            var duck = new Duck(birdAnimal, walkable, swimable);



            var fileManager = new FileManager();

            //fileManager.CreateCsharpAdvancedDirectory("0-c#-advanced");
            //fileManager.CreateCsharpAdvancedFile("Program.cs");



            var emmy = new Person2("Emmanuel");

            // Console.WriteLine(emmy.FullName);

            // emmy.Walk();


            var list = new CustomList<int>();

            list.Add(5);
            list.Add(10);
            list.Add(20);



            // for(int i = 0; i < list.Count; i ++){
            //     Console.WriteLine(list[i]);
            // }



            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            var customFilters = new CustomPhotoFilters();


            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyOpacity;
            filterHandler += customFilters.ApplyRedEye;

            //photoProcessor.Process("photo.jpg", filterHandler);



            var lambdaExpression = new LambdaExpression();


            Console.WriteLine(lambdaExpression.Add(5, 5));
            Console.WriteLine(lambdaExpression.AddWithLambda(5, 5));


            Console.WriteLine("\n");



            Console.WriteLine(lambdaExpression.Subtract(5, 5));
            Console.WriteLine(lambdaExpression.SubtractWithLambda(5, 5));





            var videoEncoder = new VideoEncoder();

            var mailService = new MailService();
            var textMessageService = new TextMessageService();



            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textMessageService.OnVideoEncoded;

            videoEncoder.Encode();




            // string confession1 = "I love C#";

            // Console.WriteLine(confession1.GetWordCount());
            // Console.WriteLine(confession1.GetWordCount().GetType());





            // int[] numbers = { 1, 2, 3, 4, 5 };
            // Console.WriteLine(numbers.Add());


            // var num1 = 28;


            // Console.WriteLine(num1.Square());





            // var books = new Book().GetAllBooks();

            // List<Book> cheapBooks = new List<Book>();


            // foreach (Book book in books)
            // {
            //     if (book.Price < 30)
            //     {
            //         cheapBooks.Add(book);
            //     }
            // }


            // foreach (Book book in cheapBooks)
            // {

            //     Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
            // }


            // // Using LINQ to filter books with price less than 30


            // var cheapBooks2 = books.Where(book => book.Price < 30);



            // foreach (Book book in cheapBooks2)
            // {

            //     Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
            // }


            // // Using LINQ query syntax to filter books with price less than 30

            // var cheapBooks3 = from book in books
            //                   where book.Price > 30 & book.Author == "Adedoyin Emmanuel"
            //                   & book.Title == "C# Intermediate"
            //                   | book.Title == "C# Advanced"
            //                   select book;



            // foreach (Book book in cheapBooks3)
            // {

            //     Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
            // }



            // var user1 = new User() { Name = "Adedoyin Emmanuel", Age = 18 };

            // user1.Introduce();


            // User user2 = new User();

            // user2.Introduce();




            // // Exceptions

            // try
            // {
            //     int[] nums = [1, 2, 3, 4, 5];

            //     Console.WriteLine(nums[10]);
            // }
            // catch (IndexOutOfRangeException exception)
            // {
            //     Console.WriteLine("This exception will run because it is more specific");
            //     Console.WriteLine(exception.GetType());
            // }
            // catch (Exception exception)
            // {
            //     Console.WriteLine(exception.GetType());
            //     Console.WriteLine(exception.Message);
            // }



            // try
            // {
            //     int x = 10;

            //     Console.WriteLine(x / 0);
            // }
            // catch (DivideByZeroException exception)
            // {
            //     Console.WriteLine("You cannot divide by Zero");
            //     Console.WriteLine(exception.GetType());
            //     Console.WriteLine(exception.Message);

            // }



            // try{

            //     throw new CustomException("Something went wrong", new Exception("This is the inner exception"));

            // }catch(CustomException ex){
            //     Console.WriteLine(ex.GetType());
            //     Console.WriteLine($"Caught an exception: {ex.Message}");
            //     Console.WriteLine(ex?.InnerException?.Message);
            // }


            await FetchTodo();
        }
    }
}