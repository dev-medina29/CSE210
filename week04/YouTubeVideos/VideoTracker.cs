using System;
using System.Collections.Generic;
class VideoTracker
{
    private List<string> videos;
    private List<string> comments;
    public VideoTracker()
    {
        videos = new List<string>();
        comments = new List<string>();
    }

    // added author and duration
    public void AddVideo(string videoTitle, string author, int duration)
    {
        var videoInfo = $"{videoTitle},{author},{duration}";
        videos.Add(videoInfo);
        
    }
    // get the title
    public void GetTitle()
    {
        var parts = videos[0].Split(',');
        Console.WriteLine(parts[0]);
    }
    // get the author
     public void GetAuthor()
    {
        var parts = videos[0].Split(',');
        Console.WriteLine(parts[1]);
    }
    // get the duration
     public void GetLength()
    {
        var parts = videos[0].Split(',');
        Console.WriteLine(parts[2]);
    }
    // store a list of comments and return the number of comments
    public void AddComment(string videoTitle, string comment)
    {
        comments.Add($"{videoTitle}: {comment}");
    }    
    public int NumberOfComments()
    {
        return comments.Count;
    }
}