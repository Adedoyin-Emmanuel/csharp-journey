using System;

namespace CSharpJourney{


    class CSharpClasses{



        readonly string name;
        readonly string hobbies;



        // let's work with access modifiers

        private bool _hasGirlfriend;


        // let's work with setters and getters

        public  DateTime BirthDate { set; get; }

        public double  Age {
            get{
                var timestamp = DateTime.Now - BirthDate;
                var years = timestamp.Days / 365;

                return years;
            }
          
        }

        



        /*
            So based on what I learnt from Mosh Hamedani

            A C# class can have multiple constructors but the 
            constructors should have different signatures.

            Signatures as in the constructor 


            Let's try to break that and see if the C# compiler
            will complain.  Oh yeah, it is complaining 🤣

        */


        public CSharpClasses(string name, string hobbies){

            this.name = name;
            this.hobbies = hobbies;
            this._hasGirlfriend = false;

        

        }



        public void Introduce (){
            var hasGirlfriendString = "";

           if(_hasGirlfriend){
                hasGirlfriendString = "I've a girlfriend";
           }else{
                hasGirlfriendString = "I don't have a girlfriend";
           }

            Console.WriteLine("Hi, my name is {0}. I'm {1} years old. {2}  I love {3}", name, Age, hasGirlfriendString, hobbies);
        }


        public void setGirlfriend(bool value){
            _hasGirlfriend = value;
        
        }


        public bool getGirlfriend(){
            return _hasGirlfriend;

        }


        


    }
}