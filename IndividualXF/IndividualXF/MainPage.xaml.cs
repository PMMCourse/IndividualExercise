using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;

namespace IndividualXF
{
    public partial class MainPage : ContentPage
    {

        List<Post> listaPosts = new List<Post>();

        public MainPage()
        {
            InitializeComponent();

            HttpClient httpClient = new HttpClient();
            string postsJSON = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
            listaPosts = JsonConvert.DeserializeObject<List<Post>>(postsJSON);
            lbPost.ItemsSource = listaPosts;
        }


        private void LbPost_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new ViewPost(e.SelectedItem as Post));
        }

        private void SbPost_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(sbPost.Text.ToLower()))
            {
                var postFiltrados = listaPosts.Where(post => post.Title.ToLower().StartsWith(sbPost.Text.ToLower())).ToList();
                lbPost.ItemsSource = null;
                lbPost.ItemsSource = postFiltrados;
            }
            else
            {
                lbPost.ItemsSource = listaPosts;
            }
        }
    }
}
