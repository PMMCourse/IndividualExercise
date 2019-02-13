using EjercicioIndPmm.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace EjercicioIndPmm
{
    public partial class MainPage : ContentPage
    {
        private List<Post> tempdata = new List<Post>();

        private const string url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<Post> _post;
        public MainPage()
        {
            InitializeComponent();

            Post_List.ItemsSource = new List<ListViewTemplate>

           {
           new ListViewTemplate
               {
               Name = "Xamarin.Forms",
                   Description = "One",
                   OrderNumber = 1
              },
              new ListViewTemplate
              {
                  Name = "Android",
                  Description = "Two",
                  OrderNumber = 2
               },
               new ListViewTemplate
               {
                   Name = "IOS",
                   Description = "Three",
                   OrderNumber = 3
              },
              new ListViewTemplate
              {
                  Name = "Windows",
                  Description = "Four",
                  OrderNumber = 4
              }
          };
        }

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as Post;

            await Navigation.PushAsync(new Page1(Selected));

            ((ListView)sender).SelectedItem = null;

        }
        protected override async void OnAppearing()
        {
            var content = await _Client.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<List<Post>>(content);
            _post = new ObservableCollection<Post>(post);
            Post_List.ItemsSource = _post;
            base.OnAppearing();
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //thats all you need to make a search

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                Post_List.ItemsSource = _post;
            }

            else
            {
                Post_List.ItemsSource = _post.Where(x => x.title.StartsWith(e.NewTextValue));
            }
        }
    }
}