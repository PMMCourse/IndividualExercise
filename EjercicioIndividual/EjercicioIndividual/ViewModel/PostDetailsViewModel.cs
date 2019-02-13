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
        private PostDetails Context;
        //private INavigation navigation;

        public ICommand PerformAddComment;
        public PostDetailsViewModel(Post post)
        {
            id = post.Id;
            userId = post.UserId;
            title = post.Title;
            description = post.Description;
            comments = post.Comments;
            PerformAddComment = new Command(AddComment);
            //this.navigation = navigation;
        }
        
        public void AddComment()
        {
            
            //navigation.NavigationStack.FirstOrDefault<PostDetails>().DisplayAlert("","Thank you for commenting ","Ok");
        }
    }
}
