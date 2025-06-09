using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("C# for Beginners", "Mr. Tech", 416);
        vid1.addComment(new Comment("Wow, this helped me so much!", "Dean H."));
        vid1.addComment(new Comment("Thank you for making this video!", "Taylor D."));
        vid1.addComment(new Comment("Can you also make a video on Python?", "Raul R."));

        Video vid2 = new Video("Come, Follow Me - Week 23", "Brother Smith", 723);
        vid2.addComment(new Comment("Glad I found this today.", "Bryce K."));
        vid2.addComment(new Comment("Great insights!", "Will C."));
        vid2.addComment(new Comment("You explain this so well.", "Joey S."));

        Video vid3 = new Video("Top 10 Hikes in Idaho", "HikerClub", 300);
        vid3.addComment(new Comment("Been to all 10, they're great!", "Ben J."));
        vid3.addComment(new Comment("Now I really want to go to Idaho..", "Carter G."));
        vid3.addComment(new Comment("Missing a couple of hikes in Stanley, but pretty good list.", "Dan J."));

        List<Video> videosList = new List<Video>();
        videosList.Add(vid1);
        videosList.Add(vid2);
        videosList.Add(vid3);

        foreach (Video vid in videosList)
        {
            Console.WriteLine($"Title: {vid.getTitle()}");
            Console.WriteLine($"Author: {vid.getAuthor()}");
            Console.WriteLine($"Length: {vid.getLength()} seconds");
            Console.WriteLine($"# of Comments: {vid.getNumberComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment com in vid.getComments())
            {
                Console.WriteLine($" - {com.getUser()}: {com.getComment()}");
            }

            Console.WriteLine();
        }
        
    }
}