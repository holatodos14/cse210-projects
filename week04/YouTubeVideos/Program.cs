using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C#", "John Doe", 600);
        Video video2 = new Video("Advanced C# Programming", "Jane Smith", 1200);
        Video video3 = new Video("C# Design Patterns", "Alice Johnson", 900);

        video1.AddComment(new Comment("User1", "Nice"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "I learned a lot from this video."));

        video2.AddComment(new Comment("User4", "This is too advanced for me."));
        video2.AddComment(new Comment("User5", "Excellent explanation of advanced concepts."));
        video2.AddComment(new Comment("User6", "Could you make a video on Facebook?"));

        video3.AddComment(new Comment("User7", "Design patterns are so important!"));
        video3.AddComment(new Comment("User8", "This video clarified a lot for me."));
        video3.AddComment(new Comment("User9", "I wish there were more examples."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}