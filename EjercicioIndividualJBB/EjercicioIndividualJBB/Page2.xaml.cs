
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjercicioIndPmm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(Post x)
        {
            InitializeComponent();

            titulo.Text = x.title;
            contenido.Text = x.body;

            userId.Text = $"user id{x.userId}";
            id.Text = $"id {x.id}";
        }
        public void mensaje(object sender, EventArgs e)
        {
            this.DisplayAlert("", "thanks for your comment", "ok");
        }
    }
}