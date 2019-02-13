using System;
using System.Collections.Generic;
using System.Text;

namespace IndividualXF
{
    public class Post
    {
        int userId, id;
        string title, body;

        public int UserId { get => userId; set => userId = value; }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }


    }
}
