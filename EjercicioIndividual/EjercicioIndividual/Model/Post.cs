using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioIndividual.Model
{
    public class Post
    {
        private int id;
        public int Id
        {
            get => id;
            set=> id = value;
                
            
        }
        [JsonProperty("body")]
        private string description;
        public string Description
        {
            get => description;
            set => description = value;
        }

        private List<String> Comments;

        public Post(int id, string description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
