using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Ancient Mysteries", "Uncharted Mysteries", "1700");
        video1.AddComment(new Comment("Billy", "Awesome video!"));
        video1.AddComment(new Comment("Newtings", "So many cool mysteries!!"));
        video1.AddComment(new Comment("Grogu", "How did this all happen?"));
        videos.Add(video1);

        Video video2 = new Video("Repo w/friends", "Grizzy", "650");
        video2.AddComment(new Comment("DragonPrince", "So hiliarous!!"));
        video2.AddComment(new Comment("Cali", "This game is so fun with friends"));
        video2.AddComment(new Comment("GillyRocks", "lol"));
        videos.Add(video2);

        Video video3 = new Video("How to fix an iPhone screen", "Fix-it man", "780");
        video3.AddComment(new Comment("Soph", "Great video!"));
        video3.AddComment(new Comment("Bradys", "Very helpeul"));
        video3.AddComment(new Comment("Boba", "so easy to follow along, thanks"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}