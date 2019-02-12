using EjercicioIndividual.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using EjercicioIndividual.Services;

namespace EjercicioIndividual.ViewModel
{
    class PostsViewModel : BindableObject
    {
        public ObservableCollection<Post> Posts { get; set; }
        public IGetPostsService GetPostsService;

        public PostsViewModel()
        {
            
        }
    }
}
