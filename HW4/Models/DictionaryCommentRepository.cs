using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    public class DictionaryCommentRepository
    {
        private int nextID = 0;
        private Dictionary<int, Comment> repository = new Dictionary<int, Comment>();

        #region GET
        public IEnumerable<Comment> Get()
        {
            return repository.Values;
        }

        public bool TryGet(int id, out Comment comment) => repository.TryGetValue(id, out comment);
        #endregion

        #region ADD
        public Comment Add(string author, string text)
        {
            Comment comment = new Comment(nextID, author, text);
            repository.Add(nextID, comment);
            ++nextID;
            return comment;
        }
        #endregion

        #region DELETE
        public bool Delete(int id)
        {
            if (repository.ContainsKey(id))
            {
                return repository.Remove(id);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region UPDATE
        public bool Update(int id, string author, string text)
        {
            if (repository.ContainsKey(id))
            {
                Comment comment = repository[id];
                comment.Author = author;
                comment.Text = text;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}