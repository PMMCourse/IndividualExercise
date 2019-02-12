using App1.Clases;
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
    public partial class PagePost: ContentPage {

        Post post;
        public PagePost(Post post1) {
            InitializeComponent();
            //aqui cambiamos el contenido de los labels por los que nos traemos de la lista Posts
            post = post1;
            user.Text = $"User Id:{post1.userId}";
            id.Text = $"Post Id:{post1.id}";
            title.Text = post1.title;
            body.Text = post1.body;
        }//Fin Constructor

        public void buttonClick(object sender, EventArgs e) {
            string comentario;
            comentario = entry.Text;

            this.DisplayAlert("", "Gracias por el comentario", "ok");


        }


    }
}