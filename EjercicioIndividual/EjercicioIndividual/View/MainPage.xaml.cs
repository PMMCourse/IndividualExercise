using EjercicioIndividual.Model;
using EjercicioIndividual.View;
using EjercicioIndividual.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjercicioIndividual
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.BindingContext = new MainPageViewModel();
		}

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var post = e.SelectedItem as Post;
            if (post == null)
                return;
            await Navigation.PushAsync(new PostDetails(new PostDetailsViewModel(post)));

            PostsListView.SelectedItem = null;

        }
    }
}
