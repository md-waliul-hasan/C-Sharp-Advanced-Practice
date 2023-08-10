using System;
namespace C_Sharp_Advanced_Practice.Topics.Events
{
	public class MailService
	{
		public void OnVideoEncoded(object source, VideoEventArgs args)
		{
            Console.WriteLine($"Message Service starts....: {args.Video.Title}");
        }
	}
}

