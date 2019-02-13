using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndividualXF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewPost : ContentPage
	{

        public ViewPost (Post articulo)
		{
			InitializeComponent ();
            Id.Text = "User Id: "+articulo.UserId.ToString()+"  Post Id: "+articulo.Id.ToString();
            Title.Text = articulo.Title;
            Body.Text = articulo.Body;
        }

        private void btComment(object sender, EventArgs e)
        {
            DisplayAlert("","Gracias por su comentario","","OK");
        }
    }
}