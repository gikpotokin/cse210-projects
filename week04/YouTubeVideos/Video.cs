using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        // Member variables
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;

        // Constructor
        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        // Getters
        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLength()
        {
            return _length;
        }

        // Add a comment to the video
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}