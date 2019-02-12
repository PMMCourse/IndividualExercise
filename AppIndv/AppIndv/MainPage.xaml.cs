using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace AppIndv
{
    public partial class MainPage : ContentPage
    {
        private const string url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient client = new HttpClient();
        private List<Posts> postsList;

        public MainPage()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            var content = await client.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<List<Posts>>(content);
            postsList = new List<Posts>(post);
            Post_List.ItemsSource = postsList;
            base.OnAppearing();
        }

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as Posts;
            await Navigation.PushAsync(new PagePost(Selected));

            ((ListView)sender).SelectedItem = null;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                Post_List.ItemsSource = postsList;
            }
            else
            {
                Post_List.ItemsSource = postsList.Where(x => x.title.Contains(e.NewTextValue));
            }
        }
    }
}
