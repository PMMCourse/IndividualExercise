using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace XamarinIndividual
{
    public partial class MainPage : ContentPage
    {
        private const string url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient cliente = new HttpClient();
        private List<Post> posts = new List<Post>();

        public MainPage()
        {
            InitializeComponent();
            Post_List.ItemsSource = posts;
        }

        protected override async void OnAppearing()
        {
            var content = await cliente.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<List<Post>>(content);
            posts = new List<Post>(post);
            Post_List.ItemsSource = posts;
            base.OnAppearing();
        }



        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as Post;

            await Navigation.PushAsync(new Page1(Selected));


            ((ListView)sender).SelectedItem = null;


        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                Post_List.ItemsSource = posts;
            }

            else
            {
                Post_List.ItemsSource = posts.Where(x => x.title.Contains(e.NewTextValue));

            }
        }

    }
}
