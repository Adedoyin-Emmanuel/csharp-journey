using System;



namespace CSharpJourney { 

    class VideoEncoder{


        public delegate void VideoEncodedEventHandler(object sender, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

     

        public void Encode(){
            Console.WriteLine("Encoding video");

            OnVideoEncoded();
        }



        protected virtual void OnVideoEncoded(){
            VideoEncoded(this, EventArgs.Empty);
        }
    }


}