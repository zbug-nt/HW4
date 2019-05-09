using HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HW4.Controllers
{
    public class CommentsController : ApiController
    {
        // GET api/values
        public IEnumerable<Comment> Get()
        {
            return new Comment[1];
        }

        // GET api/values/5
        public Comment Get(int id)
        {
            return new Comment();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
