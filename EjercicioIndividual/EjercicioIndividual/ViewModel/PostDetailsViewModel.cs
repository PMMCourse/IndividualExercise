using EjercicioIndividual.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using EjercicioIndividual.View;
using System.Linq;

namespace EjercicioIndividual.ViewModel
{
    public class PostDetailsViewModel : BindableObject
    {
        private int id;
        public int Id
        {
            get => id;
            set => id = value;

        }

        private string newComment;
        public string NewComment
        {
            get => newComment;
            set
            {
                newComment = value;
                OnPropertyChanged();
            }
        }
        private int userId;
        public int UserId{ get=>userId; set=>userId=value; }
        private string title;
        public string Title { get=>title; set=>title=value; }
        private string description;
        public string Description { get=>description; set=>description=value; }
        private List<string> comments;
       

        public ICommand PerformAddComment;
        public PostDetailsViewModel(Post post)
        {
            id = post.Id;
            userId = post.UserId;
            title = post.Title;
            description = post.Description;
            comments = post.Comments;
            PerformAddComment = new Command(AddComment);
            comments = new List<string>();
        }
        
        public void AddComment()
        {
            if (newComment == null || newComment == string.Empty)
                return;
            comments.Add(newComment);
            NewComment = string.Empty;
        }
    }
}
