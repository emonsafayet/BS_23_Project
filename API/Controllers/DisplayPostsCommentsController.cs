using API.Models;
using Client.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class DisplayPostsCommentsController : ApiController
    {

        public HttpResponseMessage Get(int pageNo = 1)
        {
            HttpResponseMessage response = null;
            int totalPage, totalRecord, pageSize;
            pageSize = 2;
            using (DBEntities db = new DBEntities())

            {
                totalRecord = db.Posts.Count();
                totalPage = (totalRecord / pageSize) + ((totalRecord % pageSize) > 0 ? 1 : 0);
                var record = (from p in db.Posts
                              orderby p.PostedDate descending
                              select p).Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();
                DisplayPostComment datas = new DisplayPostComment
                {
                    posts = record,
                    TotalPage = totalPage
                };
                response = Request.CreateResponse(HttpStatusCode.OK, datas);
                return response;
            }
        }



    }
}
