using IActivityPana1.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using IactivityPana1.Model;
using IactivityPana1.View;

namespace IactivityPana1
{
    public partial class MainPage 
    {
        public ObservableCollection<RootObject> Items { get; set; }



        public MainPage()
        {
            InitializeComponent();
            BindingContext = new IndexViewModel();
            Items = new ObservableCollection<RootObject>();
        }

        private void Busqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
              var tempRecords = ((IndexViewModel)BindingContext).Items.Where(c => c.title.Contains(busqueda.Text));
               ObservableCollection<RootObject> Items2 = new ObservableCollection<RootObject>();

              foreach (var item in tempRecords)
                 {
       
                Items2.Add(item);
               }
             lista.ItemsSource = Items2;



        }

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {            
            var selectedItem = e.Item as RootObject;
            await Navigation.PushAsync(new VistaPost(selectedItem)); 
        }
    }
}