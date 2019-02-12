using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using App1.Clases;

namespace App1 {
    public partial class MainPage: ContentPage {

        private const string url = "https://jsonplaceholder.typicode.com/posts";//aqui importamos el JSON
        private HttpClient cliente = new HttpClient();
        private List<Post> posts = new List<Post>();

        public MainPage() {
            InitializeComponent();
        }//Fin constructor


        //Metemos el JSON en la lista y la cargamos en el listView
        protected override async void OnAppearing() {
            var content = await cliente.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<List<Post>>(content);
            posts = new List<Post>(post);
            MainListView.ItemsSource = posts;
            base.OnAppearing();
        }//Fin Metodo

        //Aqui le decimos que al pulsar una persona la pase como parametro a la nueva pantalla y la muestre 
        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e) {
            var Selected = e.Item as Post;

            await Navigation.PushAsync(new PagePost(Selected));

            ( ( ListView )sender ).SelectedItem = null;
        }//Fin metodo

        //Metodo para la barra de busqueda
        private void SearchBar(object sender, TextChangedEventArgs e) {
            if (string.IsNullOrEmpty(e.NewTextValue)) {
                MainListView.ItemsSource = posts;
            } else {
                MainListView.ItemsSource = posts.Where(x => x.title.StartsWith(e.NewTextValue));
            }
        }//Fin Metodo






    }//Fin MainPage
}
