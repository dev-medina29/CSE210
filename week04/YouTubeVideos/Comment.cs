using System;
using System.Collections.Generic;
class Comment
{
   
    List<string> ListComments = new List<string>

    {
        "Great explanation!",
        "Very helpful, thanks!",
        "I learned a lot from this video.",
        "Can you make a tutorial on async/await?",
        "Looking forward to more content!",
        "Clear and concise presentation.",
        "Awesome editing!",
        "Subbed for more videos.",
        "This solved my problem.",
        "Keep up the good work!"
    };
    List<string> authors = new List<string>
    {
        "Alice",
        "Bob",
        "Charlie",
        "Dana",
        "Eve",
        "Frank",
        "Grace",
        "Heidi",
        "Ivan",
        "Judy"
    };
    Random random = new Random();
    string commenterName;
    string text;
    public string author()
    {
        // Initialize with random comment
        commenterName = authors[random.Next(authors.Count)];
        return $"{commenterName}";
    }
    
    public string comment()
    {
        text = ListComments[random.Next(ListComments.Count)];
        return $"{text}";
    }







}
