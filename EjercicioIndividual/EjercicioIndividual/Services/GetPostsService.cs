using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndividual.Model;
using Newtonsoft.Json;

namespace EjercicioIndividual.Services
{
    class GetPostsService : IGetPostsService
    {
        private string json;
        public List<Post> GetAllPosts()
        {

            HttpClient httpClient = new HttpClient();
            json = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(json);

            return posts;
        }

        private async void HttpCall()
        {
            
        }
    }
}
