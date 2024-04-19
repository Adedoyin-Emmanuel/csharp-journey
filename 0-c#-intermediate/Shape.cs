using System;

namespace CSharpJourney
{


    /*
        I will use this to work with Abstract classes and methods
    */

    abstract class Shape{

        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public Shape(string name, int width, int height){
            this.Name = name;
            this.Width = width;
            this.Height = height;
        }


         public abstract void Draw();


         
    }
}