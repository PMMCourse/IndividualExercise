using EjercicioIndividual.Model;
using EjercicioIndividual.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

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
        private string search;
        public string Search
        {
            get => search;
            set
            {
                search = value;
                OnPropertyChanged();
            }
        }
        private List<Post> allposts;
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
            allposts = getPostsService.GetAllPosts();
            posts = allposts;
            ExecuteRefreshList = new Command(RefreshList);
            
        }

        private void RefreshList()
        {
            if (search == null)
                return;
            if (search == string.Empty)
            {
                posts = allposts;
            }
            else
            {
                posts = allposts.Where(x => x.Title.Contains(search)).ToList();
            }
            OnPropertyChanged("Posts");
        }

        public Command ExecuteRefreshList { get; set; }


    }
}
