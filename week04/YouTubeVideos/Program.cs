
using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

            // INSTRUCTIONS/NOTES:
            //
            // This program demonstrates the principle of abstraction by using separate
            // classes to represent YouTube videos and the comments associated with them.
            //
            // - Program.cs creates the videos and comments, adds comments to each video,
            //   stores the videos in a list, and displays the video information.
            // - Video.cs stores the title, author, and length of each video and manages
            //   the list of comments associated with the video.
            // - Comment.cs stores the name of the person who made a comment and the
            //   text of the comment.
            //
            // The program creates 4 videos, adds 3-4 comments to each video, and then
            // loops through the list of videos to display each video's information,
            // number of comments, and all comments.
            //
            // Author: Godswill Moses Ikpotokin
            // CEO & Software Developer, Applinet Technology
            // Student, BYU-Pathway Worldwide


            Video video1 = new Video(
                "Introduction to Web Development",
                "CodeHouse Cloud",
                600
            );

            video1.AddComment(new Comment(
                "John",
                "This is a very helpful introduction to web development."
            ));

            video1.AddComment(new Comment(
                "Mary",
                "I learned a lot from this video. Thank you!"
            ));

            video1.AddComment(new Comment(
                "David",
                "I am looking forward to watching more videos like this."
            ));

            // Create the second video
            Video video2 = new Video(
                "Learning C# Programming",
                "Programming Academy",
                900
            );

            video2.AddComment(new Comment(
                "Sarah",
                "C# is becoming one of my favorite programming languages."
            ));

            video2.AddComment(new Comment(
                "Michael",
                "The explanation of classes was excellent."
            ));

            video2.AddComment(new Comment(
                "Daniel",
                "This video made object-oriented programming easier to understand."
            ));

            video2.AddComment(new Comment(
                "Grace",
                "Great tutorial. I will definitely recommend it."
            ));

            // Create the third video
            Video video3 = new Video(
                "Introduction to Artificial Intelligence",
                "African Tech Hub",
                1200
            );

            video3.AddComment(new Comment(
                "Peter",
                "AI is changing the world in so many ways."
            ));

            video3.AddComment(new Comment(
                "Esther",
                "I really enjoyed learning about artificial intelligence."
            ));

            video3.AddComment(new Comment(
                "James",
                "This was a very informative presentation."
            ));

            // Create the fourth video
            Video video4 = new Video(
                "Building Software Projects",
                "Tech Developers",
                750
            );

            video4.AddComment(new Comment(
                "Robert",
                "I like the practical approach used in this video."
            ));

            video4.AddComment(new Comment(
                "Jennifer",
                "The project examples were very useful."
            ));

            video4.AddComment(new Comment(
                "Samuel",
                "I am going to use these ideas in my next project."
            ));

            video4.AddComment(new Comment(
                "Elizabeth",
                "Excellent content and great explanation."
            ));

            // Create a list of videos
            List<Video> videos = new List<Video>
            {
                video1,
                video2,
                video3,
                video4
            };

            // Display information about each video
            foreach (Video video in videos)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetLength()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("----------------------------------------");

                // Display each comment
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"Commenter: {comment.GetName()}");
                    Console.WriteLine($"Comment: {comment.GetText()}");
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}