using EjercicioIndividual.Model;
using EjercicioIndividual.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EjercicioIndividual.ViewModel
{
    public class MainPageViewModel : BindableObject
    {
        private string test = "My Posts";
        public string Test
        {
            get => test;
            set
            {
                test = value;
                OnPropertyChanged();
            }
        }
        private List<Post> posts;
        private IGetPostsService getPostsService;
        public List<Post> Posts
        {
            get => posts;
            set
            {
                posts = value;
                OnPropertyChanged();
            }
        }
        

        public MainPageViewModel()
        {
            getPostsService = new GetPostsService();
            posts = getPostsService.GetAllPosts();
            OnPropertyChanged();
            
        }
    }
}
