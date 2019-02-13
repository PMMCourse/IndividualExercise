using EjercicioIndividual.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndividual.Services
{
    interface IGetPostsService
    {
        Task<List<Post>> GetAllPosts();
    }
}
