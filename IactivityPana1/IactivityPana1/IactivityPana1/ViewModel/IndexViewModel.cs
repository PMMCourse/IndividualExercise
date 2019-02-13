using IactivityPana1.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using Xamarin.Forms;
using IactivityPana1.View;
using System.Linq;

namespace IActivityPana1.ViewModel
{

    public class IndexViewModel : BindableObject
    {
        private const string url = "https://jsonplaceholder.typicode.com/posts";
        private ObservableCollection<RootObject> _post;
        private ListView Post_list { get; set; }
        private string busqueda { get; set; }

        public ObservableCollection<RootObject> Items { get; set; }

        public IndexViewModel()
        {
            string json = new WebClient().DownloadString(url);
            var post = JsonConvert.DeserializeObject<List<RootObject>>(json);
            _post = new ObservableCollection<RootObject>(post);
            Items = _post;
            
        }


        








    }
}
