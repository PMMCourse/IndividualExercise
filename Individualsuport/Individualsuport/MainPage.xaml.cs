using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Individualsuport
{
    public partial class MainPage : ContentPage
    {
        private const string url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<Posts> _post;
        private List<Posts> tempdata=new List<Posts>();

        public MainPage()
        {
            InitializeComponent();

           List_Post.ItemsSource = _post;


            
        }
        protected override async void OnAppearing()
        {
            var content = await _Client.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<List<Posts>>(content);
            _post = new ObservableCollection<Posts>(post);
            List_Post.ItemsSource = _post;
            base.OnAppearing();
        }
        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
            var Selected = e.Item as Posts;
            await Navigation.PushAsync(new Page2(Selected));

            ((ListView)sender).SelectedItem = null;

        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var palabra = barra.Text;

            var result = _post.Where(x => x.title.Contains(palabra)).ToList();
            List_Post.ItemsSource = result;
        }
    }
}
      

 