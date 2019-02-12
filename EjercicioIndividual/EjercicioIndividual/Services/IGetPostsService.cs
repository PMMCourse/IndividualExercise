using EjercicioIndividual.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioIndividual.Services
{
    interface IGetPostsService
    {
         List<Post> GetAllPosts();
    }
}
