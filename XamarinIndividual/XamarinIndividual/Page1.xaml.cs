using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinIndividual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        Post post;

        public Page1(Post post2)
        {
            InitializeComponent();
            post = post2;
            userid.Text = $"User Id:{post2.userId}";
            Postid.Text = $"Post Id:{post2.id}";
            title.Text = post2.title;
            body.Text = post2.body;
        }

        public void cliclar(Object sender, EventArgs e)
        {
            this.DisplayAlert("", "Thanks for your comment noob", "ok");
        }
    }
}