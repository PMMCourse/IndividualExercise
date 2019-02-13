using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageContenido : ContentPage
	{
        Post post;
		public PageContenido (Post p)
		{
			InitializeComponent ();
            post = p;
            BindingContext = post;
		}

        //Mensaje de alerta 
        async private void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thanks for your comment", "", "OK");
        }
    }
}