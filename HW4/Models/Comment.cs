using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    public class Comment
    {
        public Comment(int id, string author, string text)
        {
            ID = id;
            Author = author;
            Text = text;
        }

        public int ID { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
    }
}