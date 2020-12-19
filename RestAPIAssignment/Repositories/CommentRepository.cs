using RestAPIAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPIAssignment.Repositories
{
  
    
        public class CommentRepository : Repository<Comment>
        {
        public List<Comment> GetCommentsByPost(int id)
        {
            return this.GetAll().Where(x => x.PostID == id).ToList();
        }

        internal void Update(Post comment)
        {
            throw new NotImplementedException();
        }
    }
    
}