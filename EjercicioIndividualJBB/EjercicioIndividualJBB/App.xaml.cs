using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
using EjercicioIndividualJBB;
using EjercicioIndPmm;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EjercicioIndividualJBB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}