using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIndividual
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetallePost : ContentPage
	{
        List<Post> listaPosts;
        int idPost;

		public DetallePost (List<Post> listaPosts, int idPost)
		{
			InitializeComponent ();
            this.listaPosts = listaPosts;
            this.idPost = idPost;
            getDetallePost();
            this.Title = "Post " + (idPost + 1);
        }

        public void getDetallePost()
        {
            id.Text = "Post ID: " + listaPosts[idPost].id.ToString();
            userId.Text = "User ID: " + listaPosts[idPost].userId.ToString();
            body.Text = listaPosts[idPost].body;
            title.Text = listaPosts[idPost].title;
        }

        private void BtnAddComentario_Clicked(object sender, EventArgs e)
        {            
            DisplayAlert("Comentario enviado", "Gracias por tu comentario.", "De nada");
            comentario.Text = "";
        }

        private void Comentario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(e.NewTextValue.Length > 0)
            {
                btnAddComentario.IsEnabled = true;
            }
            else
            {
                btnAddComentario.IsEnabled = false;
            }
        }
    }
}