using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using Collections.ObjectModel;

namespace AlvaroMartin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 (Post p)
		{
			InitializeComponent ();
            titulo.Text = p.title;
            contenido.Text = p.body; userId.Text = $"Usuario: {p.userId}";
            id.Text = $"Post: {p.id}";
            comentario.Text = $"{p.comentario }";
        }

        public void mensaje(object sender, EventArgs e)
        {
            this.DisplayAlert("", "Gracias por su comentario!", "OK");
        }
    }
	
}