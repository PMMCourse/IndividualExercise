using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IactivityPana1.Model;

namespace IactivityPana1.View
{
	public partial class VistaPost : ContentPage
	{
        
        RootObject objetoPost { get; set; }
		public VistaPost (RootObject r)
		{
			InitializeComponent ();
            objetoPost = r;
            titulo.Text = objetoPost.title;
            cuerpo.Text = objetoPost.body;
            idPersona.Text = objetoPost.userId.ToString();
            id.Text = objetoPost.id.ToString();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Información", "Comentario enviado", "OK");
        }
    }
}