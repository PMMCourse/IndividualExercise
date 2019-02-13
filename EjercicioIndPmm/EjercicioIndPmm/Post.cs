using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace EjercicioIndPmm
{
    public class Post
    {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }        
    }

}
