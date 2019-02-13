using Xamarin.Forms;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms.Internals;

namespace AppIndividual
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            GetPosts();
        }

        List<Post> listaPosts;
        
        public async void GetPosts()
        {
            try
            {
                string URLPosts = "https://jsonplaceholder.typicode.com/posts";
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage respuestaServidor = await httpClient.GetAsync(new Uri(URLPosts));

                if (respuestaServidor.IsSuccessStatusCode)
                {
                    activityIndicator.IsRunning = false;
                    stackActivityIndicator.IsVisible = false;
                    titulo.IsVisible = true;
                    listviewPosts.IsVisible = true;
                    searchbarPosts.IsVisible = true;

                    var contenidoURL = await respuestaServidor.Content.ReadAsStringAsync();
                    listaPosts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Post>>(contenidoURL);
                    listviewPosts.SelectionMode = ListViewSelectionMode.None;
                    listviewPosts.ItemsSource = listaPosts;
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void SearchbarPosts_TextChanged(object sender, TextChangedEventArgs e)
        {
            listviewPosts.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                listviewPosts.ItemsSource = listaPosts;
            }
            else
            {
                listviewPosts.ItemsSource = listaPosts.Where(x => x.title.Contains(e.NewTextValue));
            }

            listviewPosts.EndRefresh();
        }

        private void ListviewPosts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetallePost(listaPosts, listaPosts.IndexOf(e.Item)));
        }
    }
}
