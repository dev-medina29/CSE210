using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Comment videoComments = new Comment();
        VideoTracker video1 = new VideoTracker();
        video1.AddVideo("Learning C#", "John Doe", 930);
        video1.AddComment("Learning C#", videoComments.comment());
        video1.AddComment("Learning C#", videoComments.comment());
        video1.AddComment("Learning C#", videoComments.comment());
       
        VideoTracker video2 = new VideoTracker();
        video2.AddVideo("Advanced C#", "Jane Smith", 1200);
        video2.AddComment("Advanced C#", videoComments.comment());
        video2.AddComment("Advanced C#", videoComments.comment());
        video2.AddComment("Advanced C#", videoComments.comment());
        video2.AddComment("Advanced C#", videoComments.comment());
       
        VideoTracker video3 = new VideoTracker();
        
        video3.AddVideo("C# Design Patterns", "Alice Johnson", 1500);
        video3.AddComment("C# Design Patterns", videoComments.comment());
        video3.AddComment("C# Design Patterns", videoComments.comment());
        video3.AddComment("C# Design Patterns", videoComments.comment());
        var listOfVideos = new List<VideoTracker> { video1, video2, video3 };
        foreach (var video in listOfVideos)
        {
            video.GetTitle();
            video.GetAuthor();
            video.GetLength();
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            Console.WriteLine();
        }
        

       
    }
}