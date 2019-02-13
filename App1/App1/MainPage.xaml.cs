using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;


namespace App1
{
    public class Post
    {

        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

    }
    public partial class MainPage : ContentPage
    {
        private const String url = "https://jsonplaceholder.typicode.com/posts";

        private HttpClient HttpClient = new HttpClient();
        private ObservableCollection<Post> listaPost;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await HttpClient.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<List<Post>>(content);
            listaPost = new ObservableCollection<Post>(post);
            ListaPosts.ItemsSource = listaPost;
            base.OnAppearing();
        }

        private void BuscarPost_TextChanged(object sender, TextChangedEventArgs e)
        {
            var palabra = buscarPost.Text;
            var result = listaPost.Where(x => x.title.Contains(palabra));
            ListaPosts.ItemsSource = result;
        }

        async private void ListaPosts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Post;
            if (item == null)
                return;

            var page = new PageContenido((Post)e.Item);
           
            await Navigation.PushAsync(page);

            ((ListView)sender).SelectedItem = null;
        }
    }
}
