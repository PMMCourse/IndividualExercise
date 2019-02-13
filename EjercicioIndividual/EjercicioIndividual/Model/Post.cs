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
        private int userId;
        public int UserId
        {
            get => userId;
            set => userId = value;


        }
        [JsonProperty("body")]
        private string description;
        public string Description
        {
            get => description;
            set => description = value;
        }

        private string title;
        public string Title
        {
            get => title;
            set => title = value;
            
        }

        private List<string> comments;
        public List<string> Comments
        {
            get => comments;
            set => comments = value;
        }

        public Post(int id, string description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
