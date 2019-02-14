using AlvaroMartin.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace AlvaroMartin
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string comentario { get; set; }
    }
    

    public partial class MainPage : ContentPage
    {
        private const string url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<Post> _post;

        public MainPage()
        {
            InitializeComponent();
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
            Post_List.BeginRefresh();

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                Post_List.ItemsSource = _post;
            }
            else
            {
                Post_List.ItemsSource = _post.Where(x => x.title.StartsWith(e.NewTextValue));
            }
            Post_List.EndRefresh();
        }

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as Post;

            await Navigation.PushAsync(new Page1(Selected));

            ((ListView)sender).SelectedItem = null;
        }
       
    }
    }

