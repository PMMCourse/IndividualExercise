using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio_ma
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(Post p)

        {

            InitializeComponent(); titulo.Text = p.title;

            contenido.Text = p.body; userId.Text = $"user id{p.userId}";

            id.Text = $"id {p.id}";

        }

        public void mensaje(object sender, EventArgs e)

        {

            this.DisplayAlert("", "thanks for your comment", "ok");

        }
    }
    
}