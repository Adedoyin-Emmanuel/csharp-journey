namespace CSharpJourney
{
        class Person2(string fullName) : IPerson{

            public string FullName { get; set; } = fullName;

            public void Walk(){
                Console.WriteLine("{0} is walking", FullName); 
            }

            
        }
}