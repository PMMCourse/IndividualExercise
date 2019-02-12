using System;
using System.Collections.Generic;
using System.Text;
using EjercicioIndividual.Model;

namespace EjercicioIndividual.Services
{
    class GetPostsService : IGetPostsService
    {
        public List<Post> GetAllPosts()
        {
            return new List<Post>
            {
                new Post(1, "cocococo"),
                new Post(2,"yeeeeeeeee")
            };
        }
    }
}
