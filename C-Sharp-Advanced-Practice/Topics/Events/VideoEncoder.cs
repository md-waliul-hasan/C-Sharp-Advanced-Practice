using System;
namespace C_Sharp_Advanced_Practice.Topics.Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //*** Events 
        //A mechanism for communicating between objects
        //Used in building loosely coupled objects
        //Helps extending applications

        //*** Delegates
        //Agreement between publisher and Subscriber
        //Determines the signature of event handler methods in Subscriber

        //** Steps of event handler
        //1. Write a delegate
        //2. Define an event based on that delegate
        //3. Raise an event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);//define a delegate

        //public event VideoEncodedEventHandler VideoEncoded;//define an event

        //Instead of previous two line we can use new generic event handler
        public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video");

            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        //Raising the event
        //should be protected virtual void and starts with On+EventName
        protected virtual void OnVideoEncoded(Video video1)
        {
            if (VideoEncoded != null)//If there are subscribers notify them
                VideoEncoded(this, new VideoEventArgs() { Video = video1});

        }
    }
}

