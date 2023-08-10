
using C_Sharp_Advanced_Practice.Topics.Events;

var video = new Video() { Title = "First video" };

VideoEncoder videoEncoder = new VideoEncoder();
MailService mailService = new MailService();
MessageService messageService = new MessageService();
videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageService.OnVideoOnCoded;
videoEncoder.Encode(video);

