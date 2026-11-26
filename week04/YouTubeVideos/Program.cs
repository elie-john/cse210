
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Learning C#",
            "Programming Academy",
            600);

        video1.AddComment(new Comment("John", "Very helpful video!"));
        video1.AddComment(new Comment("Mary", "I learned something new."));
        video1.AddComment(new Comment("Peter", "Thank you for explaining."));

        Video video2 = new Video(
            "Introduction to Python",
            "Code School",
            850);

        video2.AddComment(new Comment("James", "Great tutorial."));
        video2.AddComment(new Comment("Sarah", "Easy to understand."));
        video2.AddComment(new Comment("David", "Please make more videos."));

        Video video3 = new Video(
            "HTML and CSS Basics",
            "Web Development Hub",
            720);

        video3.AddComment(new Comment("Alice", "I love this lesson."));
        video3.AddComment(new Comment("Michael", "Very informative."));
        video3.AddComment(new Comment("Daniel", "This helped me a lot."));

        Video video4 = new Video(
            "Introduction to JavaScript",
            "Tech Tutorials",
            900);

        video4.AddComment(new Comment("Emma", "Amazing explanation."));
        video4.AddComment(new Comment("Chris", "I finally understand JavaScript."));
        video4.AddComment(new Comment("Grace", "Thank you!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("==============================");
            video.DisplayVideo();
            Console.WriteLine("==============================");
            Console.WriteLine();
        }
    }
}