using System;

class Program
{
    static void Main(string[] args)
    {
      List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Eve", "I was confused before this."));

        Video video2 = new Video("Unity Game Tutorial", "DevUnity", 1200);
        video2.AddComment(new Comment("Carlos", "Awesome content!"));
        video2.AddComment(new Comment("Jenny", "This helped me a lot."));
        video2.AddComment(new Comment("Liam", "Nice pacing."));

        Video video3 = new Video("Product Review: SuperPhone X", "TechGuy", 480);
        video3.AddComment(new Comment("Monica", "I was thinking about buying it."));
        video3.AddComment(new Comment("Rahul", "Great review!"));
        video3.AddComment(new Comment("Zane", "Loved the detail."));

        Video video4 = new Video("How to Cook Jollof Rice", "NaijaKitchen", 900);
        video4.AddComment(new Comment("Tolu", "Looks delicious!"));
        video4.AddComment(new Comment("Amaka", "Tried it and it was awesome."));
        video4.AddComment(new Comment("Femi", "Please make one for fried rice!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display each video's details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}