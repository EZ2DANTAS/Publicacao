using Publicacao.Entities;
using System;

namespace Publicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that´s awesome");

            Post post = new Post(

                DateTime.Parse("21/06/2018 13:18:00"),
                "Traveling to new Zeland",
                "I´m going ti visit this wonderful contry",
                1300) ;
            
            post.AddComment(comment);
            post.AddComment(comment2);


            Comment commen3 = new Comment("Have a nice trip");
            Comment comment4 = new Comment("Wow that´s awesome");

            Post post2 = new Post(

                DateTime.Now,
                "Traveling to Brazil",
                "I´m going ti visit this contry",
                1900);

            post2.AddComment(commen3);
            post2.AddComment(comment4);


            Console.WriteLine(post);
            Console.WriteLine(post2);
        }
    }

}