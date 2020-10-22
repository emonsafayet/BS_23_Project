using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Web.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }   
    }
}