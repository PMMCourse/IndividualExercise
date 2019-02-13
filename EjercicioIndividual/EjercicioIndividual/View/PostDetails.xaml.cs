using EjercicioIndividual.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjercicioIndividual.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostDetails : ContentPage
    {
        public PostDetails(PostDetailsViewModel postdetailsViewModel)
        {
            InitializeComponent();
            BindingContext = postdetailsViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Thank you for commenting", "Ok");
        }
    }
}