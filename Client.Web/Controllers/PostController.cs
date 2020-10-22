using Client.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Client.Web.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            //IEnumerable<PostModel> postList;
            //HttpResponseMessage response = GlobalVariables.ApiClient.GetAsync("Post").Result;
            //postList = response.Content.ReadAsAsync<IEnumerable<PostModel>>().Result;
            //return View(postList);


            IEnumerable<PostModel> postList;
            HttpResponseMessage response = GlobalVariables.ApiClient.GetAsync("Post").Result;
            postList = response.Content.ReadAsAsync<IEnumerable<PostModel>>().Result;
            return View(postList);
        }
    }
}