using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create and populate videos with comments
        Video video1 = new Video();
        video1.SetTitle("Understanding Abstraction in Programming");
        video1.SetAuthor("TechGuru");
        video1.SetLength(600);
        video1.AddComment(new Comment("Alice", "This was a very informative video!"));
        video1.AddComment(new Comment("Bob", "Great examples, thanks!"));
        video1.AddComment(new Comment("Charlie", "I finally understand abstraction."));

        Video video2 = new Video();
        video2.SetTitle("How to Cook the Perfect Pasta");
        video2.SetAuthor("ChefDelight");
        video2.SetLength(450);
        video2.AddComment(new Comment("Dan", "Yum! Can't wait to try this recipe."));
        video2.AddComment(new Comment("Eve", "This was so helpful. Thank you!"));
        video2.AddComment(new Comment("Frank", "Could you make a video on sauces next?"));

        Video video3 = new Video();
        video3.SetTitle("Exploring the Universe");
        video3.SetAuthor("SpaceFan");
        video3.SetLength(1200);
        video3.AddComment(new Comment("Grace", "Mind-blowing content!"));
        video3.AddComment(new Comment("Hank", "I feel so small yet so curious."));
        video3.AddComment(new Comment("Ivy", "Thank you for making science so engaging."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine(); // Add space between videos
        }
    }
}