using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Client.Web.Models
{
    public class DisplayPostComment
    {
        
        public List<Post> posts { get; set; }
        public int TotalPage { get; set; }
       


    }
}