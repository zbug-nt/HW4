using HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HW4.Controllers
{
    public class CommentController : ApiController
    {
        private static DictionaryCommentRepository comments = new DictionaryCommentRepository();

        #region GET
        public IEnumerable<Comment> GetComments()
        {
            return comments.Get();
        }

        public Comment GetComment(int id)
        {
            if (comments.TryGet(id, out Comment comment))
            {
                return comment;
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
        #endregion

        #region DELETE
        public HttpResponseMessage DeleteComment(int id)
        {
            if (comments.Delete(id))
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }
        #endregion

        #region POST
        public HttpResponseMessage PostComment(Dictionary<string, string> comment)
        {
            comments.Add(comment["Author"], comment["Text"]);
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
        #endregion
    }
}
