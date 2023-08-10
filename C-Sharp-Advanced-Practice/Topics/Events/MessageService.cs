using System;
namespace C_Sharp_Advanced_Practice.Topics.Events
{
	public class MessageService
	{
		public void OnVideoOnCoded(object sender, VideoEventArgs args)
		{
			Console.WriteLine($"Message Service starts....: {args.Video.Title}");
		}
	}
}

