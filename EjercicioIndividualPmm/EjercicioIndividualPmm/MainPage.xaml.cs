using EjercicioIndividualPmm.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjercicioIndividualPmm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()  
        {  
            InitializeComponent();  
  
            MainListView.ItemsSource = new List<ListViewTemplate>  
  
            {  
            new ListViewTemplate  
                {  
                Name = "Xamarin.Forms",  
                    Description = "One",  
                    OrderNumber = 1  
               },  
               new ListViewTemplate  
               {  
                   Name = "Android",  
                   Description = "Two",  
                   OrderNumber = 2  
                },  
                new ListViewTemplate  
                {  
                    Name = "IOS",  
                    Description = "Three",  
                    OrderNumber = 3  
               },  
               new ListViewTemplate  
               {  
                   Name = "Windows",  
                   Description = "Four",  
                   OrderNumber = 4  
               }  
           };  
        }  
     async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)  
        {  
            var Selected = e.Item as ListViewTemplate;  
  
            switch (Selected.OrderNumber)  
            {  
                case 1:  
                    await Navigation.PushAsync(new pagina1());  
                    break;  
                case 2:  
                    break;  
                case 3:  
                    break;  
                case 4:  
                    break;  
            }  
  
            ((ListView)sender).SelectedItem = null;  
  
  
        }
    }
}
