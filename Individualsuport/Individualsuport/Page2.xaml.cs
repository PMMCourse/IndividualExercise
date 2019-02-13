﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Individualsuport
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        public Page2(Posts p)
        {
            InitializeComponent();

            titulo.Text = p.title;
            contenido.Text = p.body;

            userId.Text = $"user id{p.userId}";
            id.Text = $"id {p.id}";
        }
        public void mensaje(object sender, EventArgs e)
        {
            this.DisplayAlert("", "thanks for your comment", "ok");
        }
    }
}