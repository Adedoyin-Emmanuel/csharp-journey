using System;
using System.Collections.Generic;
using System.IO;


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
            var cars = new List<string>
            {
                "Buggati",
                "Camary",
                "Henenssey Venom",
                "Volvo",
                "Korope"
            };


            
            foreach (string car in cars){
                Console.WriteLine(car);
            }
        }


        public static void WorkingWithNumber(){
            Console.WriteLine("Number Max Length is {0} {1}", long.MaxValue, long.MinValue);
        }


        public static void WorkingWithDate(){
            var date = new DateTime();
            var now = DateTime.Now;

            

            Console.WriteLine(now);

            Console.WriteLine(now.ToLongDateString());

            Console.WriteLine("Today is {0}", now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());



            Console.WriteLine(now.ToString("dd-MM-yyyy"));
            Console.WriteLine(now.ToString("hh:mm:ss"));

            

            

            // It is soo painful VsCode isn't giving auto complete 

            /*
             Is it me or the C# dev kit extension doesn't work until I connect my
             PC to internet? If that be the case, that's not good enough. I'm literally
             writing raw C# at the moment, no support 😂. It is well and NEPA welldone oo,
             no power-supply since morning. I mean if not for my love for C#, why will I using
             my PC at 26%  and I know they aren't giving us power supply anytime soon. 😮‍💨 

            */

        }

        public static void WorkingWithFiles() {
            var content = File.ReadAllText("./Program.cs");
            var file = new FileInfo("README.md");

            Console.WriteLine(file.Extension);
            Console.WriteLine(file.CreationTime);


           // Console.WriteLine(content);

         }

         public  static void WorkingWithFilesUsingFileInfo(){
            var file = new FileInfo("README.md");

            Console.WriteLine("This file was last accessed on, {0}", file.LastAccessTime);
            Console.WriteLine("This file was last modified on {0}", file.LastWriteTime);
            Console.WriteLine("This file was created on {0}", file.CreationTime);
            Console.WriteLine("This file extension is {0}", file.Extension);

            if(file.Exists){
                Console.WriteLine("This file exists");
            }else{
                Console.WriteLine("This file does not exist");
            }



            /**
                I'm finding it difficult to write to a file in C#, humm, I've to make more research

            */

         }
    }

   
}
