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
        public async Task<List<Post>> GetAllPosts()
        {

            HttpClient httpClient = new HttpClient();
            json = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(json);

            return posts;
        }

     
    }
}
