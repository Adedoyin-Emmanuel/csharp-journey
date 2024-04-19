namespace CSharpJourney
{
    class Circle : Shape{

        public Circle(string name, int width, int height): base(name, width, height){
            this.Name = name;
            this.Width = width;
            this.Height = width;
        }

        public override void Draw(){
            Console.WriteLine("Drawing a circle");
        }
    }
}