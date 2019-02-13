using EjercicioIndividual.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioIndividual.ViewModel
{
    public class PostDetailsViewModel
    {
        private int id;
        public int Id
        {
            get => id;
            set => id = value;

        }
        private int userId;
        public int UserId{ get=>userId; set=>userId=value; }
        private string title;
        public string Title { get=>title; set=>title=value; }
        private string description;
        public string Description { get=>description; set=>description=value; }
        private List<string> comments;

        public PostDetailsViewModel(Post post)
        {
            id = post.Id;
            userId = post.UserId;
            title = post.Title;
            description = post.Description;
            comments = post.Comments;
        }

    }
}
