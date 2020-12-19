using RestAPIAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPIAssignment.Repositories
{
    public class Comments
    {
        public class CommentRepository : Repository<Comment>
        {
            public List<Comment> CommentsByPost(int id)
            {
                return GetAll().Where(x => x.PostID == id).ToList();
            }
            internal object Get()
            {
                throw new NotImplementedException();
            }
        }
    }
}