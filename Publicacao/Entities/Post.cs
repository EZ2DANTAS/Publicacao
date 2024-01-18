﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicacao.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; } 
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> comments { get; set; }  = new List<Comment>();

        public Post() { }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void RemoveComent(Comment comment)
        {
            comments.Remove(comment);
        }

        public override string ToString()
        {
              StringBuilder sb = new StringBuilder();
              sb.AppendLine(Title);
              sb.Append("Likes: " + Likes + " - " + Moment.ToString("dd/MM/yyyy HH:mm:ss "));
              sb.AppendLine(Content);
              sb.AppendLine("Comments");

            foreach(Comment comment in comments)
            {
                sb.AppendLine(comment.Text);
            }

            return sb.ToString();
        }
    }
}
