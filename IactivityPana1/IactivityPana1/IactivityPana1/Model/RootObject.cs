using System;
using System.Collections.Generic;
using System.Text;

namespace IactivityPana1.Model
{
    public class RootObject
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string idtitle { get { return id + " " + title; }}


    }

}

